using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using System.Threading;

namespace Programma
{
    public partial class Principale : MaterialForm
    {
        //SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'nome del database'
        //Query per prendere il nome delle tabelle di un database

        //SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = 'nome del database'
        //Query per ottenere il nome delle colonne di un database

        //SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE WHERE TABLE_NAME = 'tabella' AND TABLE_SCHEMA = 'database'
        //Query per ottenere il nome di tutte chiavi di una tabella

        //SHOW KEYS FROM tabella WHERE KEY_NAME = 'Primary'
        //Query per ottenere tutte le chiavi primarie

        //SELECT ke.REFERENCED_TABLE_SCHEMA parentSchema, ke.referenced_table_name parentTable, ke.REFERENCED_COLUMN_NAME parentColumnName, ke.TABLE_SCHEMA ChildSchema,
        //ke.table_name childTable, ke.COLUMN_NAME ChildColumnName FROM information_schema.KEY_COLUMN_USAGE ke WHERE ke.referenced_table_name IS NOT NULL
        //AND ke.REFERENCED_COLUMN_NAME = 'idCittà'
        //Query per ottenere le tabelle dove è inserita la chiave primaria

        string[] mostra;
        Size dimSchermo;
        
        public Principale()
        {
            InitializeComponent();
            dimSchermo = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            mostra = new string[] { "città", "sede", "sessione", "esami", "esaminandi", "risultato" };
            Program.query(new MySqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'esami ecdl'", Program.connection).ExecuteReader());
            creaTutto();
        }

        void creaTutto()
        {
            Controls.Add(Program.creaLabel(new Point(dimSchermo.Width / 21 * 10, dimSchermo.Height / 20 * 2), "ESAMI ECDL", "Niente", "Niente"));
            Controls[0].BackColor = Color.White;
            Controls.Add(Program.creaPanel(new Size(dimSchermo.Width, dimSchermo.Height / 6 * 5), new Point(MaximumSize.Width / 12, 140), "Principale", "Principale", Color.White, true));
            MaterialFlatButton button = new MaterialFlatButton();
            button.Location = new Point(dimSchermo.Width / 21 * 18, dimSchermo.Height / 20 * 2);
            button.Text = "visualizza skillcard";
            button.Name = "visualizza";
            button.Click += azioneBottone;
            button.Visible = false;
            Controls.Add(button);
            creaContenitore(Program.tabelle[0], "", 0, null);
        }

        void creaContenitore(string elemento, string tabPrec, int pos, Panel panel)
        {
            Panel principale = (Panel)Controls.Find("Principale", true)[0];
            principale.Controls.Add(Program.creaPanel(new Size(dimSchermo.Width / 6, principale.Height), new Point(dimSchermo.Width / 6 * pos), elemento, elemento, Color.LightGray, true));
            ((Panel)principale.Controls[principale.Controls.Count - 1]).BorderStyle = BorderStyle.FixedSingle;
            ((Panel)principale.Controls[principale.Controls.Count - 1]).DoubleClick += azioneDoubleClick;
            creaSezione(elemento, tabPrec, panel);
        }

        void creaSezione(string tag, string tabPrec, Panel panel)
        {
            Panel principale = (Panel)Controls.Find(tag, true)[0];
            principale.Controls.Add(Program.creaPanel(new Size(principale.Width - 4, principale.Height / 40 * 2), new Point(0, 0), "Titolo", "Titolo", Color.White, false));
            principale.Controls[0].Controls.Add(Program.creaLabel(new Point(principale.Controls[0].Size.Width / 23 * 10, principale.Controls[0].Size.Height / 7), "Caricamento", tag, tag));
            List<Nodo> daInserire = new List<Nodo>();
            if (tag == "città")
            {
                Program.query(new MySqlCommand("SELECT COUNT(*) FROM " + tag, Program.connection).ExecuteReader());
                int dim = Convert.ToInt32(Program.risQuery[0][0]);
                for (int i = 0; i < dim; i++)
                    daInserire.Add(Program.creaNodo(tag, i, ""));
            }
            else
            {
                int inizio = Program.tabelle.ToList().FindIndex(dato => dato == tabPrec);
                int fine = Program.tabelle.ToList().ToList().FindIndex(dato => dato == tag);
                bool eccezzione = true;
                if (inizio < fine)
                    eccezzione = false;
                daInserire = figliSucc(tag, tabPrec, creaNodoPadre(tabPrec, panel), eccezzione);
                if (tag == "risultato")
                    controlloPerRisultato(daInserire);
            }
            Program.query(new MySqlCommand("SELECT DISTINCT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = 'esami ecdl' AND TABLE_NAME = '" + tag + "'", Program.connection).ExecuteReader());
            string[] colonne = new string[Program.risQuery.Count];
            for (int i = 0; i < colonne.Length; i++)
                colonne[i] = Program.risQuery[i][0];
            for (int i = 0; i < daInserire.Count; i++)
                if (daInserire[i].Tabella == tag)
                {
                    int altezza = principale.Controls[0].Location.Y + principale.Controls[0].Size.Height;
                    if (principale.Controls.Count > 1)
                        altezza = principale.Controls[principale.Controls.Count - 1].Location.Y + principale.Controls[principale.Controls.Count - 1].Size.Height + 1;
                    Panel appoggio = Program.creaPanel(new Size(principale.Width - 3, principale.Height / 12 * 2), new Point(0, altezza), tag + (i + 1).ToString(), tag, Color.LightBlue, false);
                    for (int y = 0; y < colonne.Length; y++)
                    {
                        appoggio.Controls.Add(Program.creaLabel(new Point(appoggio.Size.Width / 7, appoggio.Size.Height / colonne.Length * y + 1), colonne[y] + ":", tag, tag + (i + 1).ToString()));
                        appoggio.Controls.Add(Program.creaLabel(new Point(appoggio.Size.Width / 7 * 4, appoggio.Size.Height / colonne.Length * y + 1), daInserire[i].valore(colonne[y]), tag, tag + (i + 1).ToString()));
                    }
                    appoggio.BorderStyle = BorderStyle.FixedSingle;
                    appoggio.DoubleClick += azioneDoubleClick;
                    appoggio.Click += azioneClick;
                    foreach (Control control in appoggio.Controls)
                    {
                        control.DoubleClick += azioneDoubleClick;
                        control.Click += azioneClick;
                    }
                    principale.Controls.Add(appoggio);
                }
            principale.Controls[0].Controls[0].Text = tag;
        }

        void controlloPerRisultato(List<Nodo> daInserire)
        {
            Panel panel = (Panel)Controls.Find("esami", true)[0];
            Panel selezionato = new Panel();
            for (int i = 0; i < panel.Controls.Count; i++)
                if (panel.Controls[i].BackColor == Color.Lime)
                    selezionato = (Panel)panel.Controls[i];
            string valore = selezionato.Controls[1].Text;
            for(int i = 0; i < daInserire.Count; i++)
                if(daInserire[i].ChiaviPrimarie[0].valore.CompareTo(valore) != 0)
                {
                    daInserire.RemoveAt(i);
                    i--;
                }
        }

        List<Nodo> figliSucc(string tag, string tabPrec, Nodo nodo, bool eccezione)
        {
            List<Nodo> daInserire = new List<Nodo>();
            List<Nodo> nodi = new List<Nodo>();
            string appoggio = "";
            int volte = 0;
            while (tag != tabPrec)
            {
                daInserire.Clear();
                List<string> chivi = Program.chiaviPrimarie(tabPrec);
                List<string[]> app = new List<string[]>();
                string cond = "";
                if (!eccezione)
                {
                    tabPrec = Program.tabelle[Program.tabelle.ToList().FindIndex(dato => dato == tabPrec) + 1];
                    if (tabPrec == "esaminandi")
                        chivi = Program.chiaviPrimarie(tabPrec);
                }
                else
                {
                    tabPrec = Program.tabelle[Program.tabelle.ToList().FindIndex(dato => dato == tabPrec) - 1];
                    chivi = Program.chiaviPrimarie(tabPrec);
                    if(nodi.Count == 0)
                        nodi.Add(nodo);
                    if (chivi.Count > 1)
                        chivi.RemoveAt(0);
                }
                int index = 0;
                if (nodi.Count > 0)
                {
                    chivi.Remove(appoggio);
                    foreach (Nodo item in nodi)
                        if (item.ChiaviPrimarie.Exists(dato => dato.nome == chivi[0]))
                            index = item.ChiaviPrimarie.FindIndex(dato => dato.nome == chivi[0]);
                    for(int i = 0; i < nodi.Count; i++)
                    {
                        cond = " WHERE " + chivi[0] + " = '" + nodi[i].ChiaviPrimarie[index].valore + "'";
                        funzione(tabPrec, cond, daInserire);
                    }
                }
                else
                {
                    cond = "REFERENCED_COLUMN_NAME = '" + chivi[0] + "'";
                    Program.query(new MySqlCommand("SELECT table_name, column_name FROM information_schema.KEY_COLUMN_USAGE WHERE referenced_table_name IS NOT NULL AND " + cond, Program.connection).ExecuteReader());
                    foreach (string[] item in Program.risQuery)
                        app.Add(item);
                    for (int i = 0; i < app.Count; i++)
                    {
                        string[] item = app[i];
                        if (item[0] == tabPrec)
                        {
                            appoggio = cond.Split('=')[1];
                            appoggio = appoggio.Remove(0, 2);
                            appoggio = appoggio.Remove(appoggio.Length - 1, 1);
                            cond = " WHERE " + item[1] + " = '" + nodo.ChiaviPrimarie[0].valore + "'";
                            funzione(tabPrec, cond, daInserire);
                        }
                    }
                }
                if(volte > 0)
                {
                    List<Nodo> variabile = new List<Nodo>();
                    foreach(Nodo item in nodi)
                        for (int i = 0; i < daInserire.Count; i++)
                            if (condizione(daInserire[i], item, index))
                                variabile.Add(daInserire[i]);
                    nodi.Clear();
                    foreach (Nodo item in variabile)
                        nodi.Add(item);

                }
                else
                {
                    nodi.Clear();
                    for (int i = 0; i < daInserire.Count; i++)
                        if (condizione(daInserire[i], nodo, 0))
                            nodi.Add(daInserire[i]);
                }
                volte++;
            }
            return daInserire;
        }

        bool condizione(Nodo ciao, Nodo nodo, int index)
        {
            if (ciao.ChiaviEsterne.Count > 0)
            {
                if (nodo.ChiaviPrimarie.Count == 1)
                {
                    if (ciao.ChiaviEsterne[0].valore == nodo.ChiaviPrimarie[index].valore)
                        return true;
                }
                else if (ciao.ChiaviPrimarie[0].valore == nodo.ChiaviPrimarie[index].valore)
                    return true;
            }
            else
            {
                Campo campo = ciao.ChiaviPrimarie.Find(dato => dato.nome == nodo.ChiaviPrimarie[index].nome);
                if (campo != null && campo.valore == nodo.ChiaviPrimarie[index].valore)
                    return true;
            }
            return false;
        }

        void funzione(string tabPrec, string cond, List<Nodo> daInserire)
        {
            Program.query(new MySqlCommand("SELECT COUNT(*) FROM " + tabPrec + cond, Program.connection).ExecuteReader());
            int dim = Convert.ToInt32(Program.risQuery[0][0]);
            for (int y = 0; y < dim; y++)
                daInserire.Add(Program.creaNodo(tabPrec, y, cond));
        }

        Nodo creaNodoPadre(string tabella, Panel panel)
        {
            int index = -1;
            string appoggio = listaChiavi(tabella, ", ");
            Program.query(new MySqlCommand("SELECT " + appoggio + " FROM " + tabella, Program.connection).ExecuteReader());
            List<string[]> app = new List<string[]>();
            foreach (string[] item in Program.risQuery)
                app.Add(item);
            for(int i = 0; i < app.Count; i++)
                if(controlloNodo(app[i], Program.chiaviPrimarie(tabella).ToArray(), panel))
                {
                    index = i;
                    i = app.Count;
                }
            return Program.creaNodo(tabella, index, "");
        }

        string listaChiavi(string tabella, string aggiunta)
        {
            string appoggio = "";
            List<string> chiavi = Program.chiaviPrimarie(tabella);
            foreach (string item in chiavi)
                appoggio += item + aggiunta;
            appoggio = appoggio.Remove(appoggio.Length - 2, 2);
            return appoggio;
        }

        bool controlloNodo(string[] valori, string[] chiavi, Panel panel)
        {
            for(int i = 0; i < chiavi.Length; i++)
            {
                bool trovato = false;
                for (int y = 0; y < panel.Controls.Count - 1; y += 2)
                    if (chiavi[i] + ":" == panel.Controls[y].Text && valori[i] == panel.Controls[y + 1].Text)
                        trovato = true;
                if (!trovato)
                    return false;
            }
            return true;
        }

        void aggiornaSezione(Panel padre, Panel selezionato, string tabella)
        {
            Panel panel = (Panel)Controls.Find(tabella, true)[0];
            panel.Controls.Clear();
            creaSezione(tabella,padre.Name, selezionato);
        }

        void azioneDoubleClick(object sender, EventArgs e)
        {
            Panel padre = new Panel(), panel = new Panel();
            trovaPanelli(ref padre, ref panel, sender);
            List<string> campi = new List<string>();
            if (!Program.tabelle.Contains(panel.Name))
            {
                panel.BackColor = Color.Lime;
                Program.query(new MySqlCommand("SELECT DISTINCT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = 'esami ecdl' AND TABLE_NAME = '" + panel.Tag.ToString() + "'", 
                                                Program.connection).ExecuteReader());
                for (int i = 0; i < panel.Controls.Count - 1; i += 2)
                    foreach (string[] item in Program.risQuery)
                        if (item[0] + ":" == panel.Controls[i].Text)
                            campi.Add(panel.Controls[i + 1].Text);
            }
            if (padre.Name != panel.Name)
            {
                int index = mostra.ToList().FindIndex(dato => dato == padre.Name) + 1;
                Panel principale = (Panel)Controls.Find("Principale", true)[0];
                if (index < mostra.Length - 1 && principale.Controls.Count > index)
                {
                    if (principale.Controls[index].Visible)
                        cambiaColoreAiCampi(panel, Color.Lime);
                    else
                        cambiaColoreAiCampi(panel, Color.LightBlue);

                }
                else
                    cambiaColoreAiCampi(panel, Color.LightBlue);
            }
            new Messaggio(panel.Tag.ToString(), campi).ShowDialog();
            int app = mostra.ToList().FindIndex(dato => dato == padre.Name);
            Nodo nodo = new Nodo();
            Panel selezionato = new Panel();
            selezionato = panelSelezionato(app);
            Panel città = panelSelezionato(0);
            switch (Program.scelta)
            {
                case "aggiungi":
                    if (app > 0)
                    {
                        if (campi.Count > 0)
                            nodo = creaNodoPadre(selezionato.Tag.ToString(), selezionato);
                        else
                            nodo = Program.creaNodo(mostra[app], -1, "");
                       new Modifiche(panel.Tag.ToString(), Convert.ToInt32(nodo.ChiaviPrimarie[0].valore), Convert.ToInt32(città.Controls[1].Text)).ShowDialog();
                    }
                    else
                    {
                        int index = 0;
                        if (padre.Name != panel.Name)
                            index = Convert.ToInt32(città.Controls[1].Text);
                        new Modifiche(panel.Tag.ToString(), int.MaxValue, index).ShowDialog();
                    }
                break;
                case "modifica":  new Modifiche(creaNodoPadre(panel.Tag.ToString(), panel)).ShowDialog(); break;
                case "elimina": elimina(creaNodoPadre(panel.Tag.ToString(), panel), panel);  break;
            }
            Program.scelta = "";
            app--;
            if (app > -1)
            {
                for(int i = app + 2; i < mostra.Length; i++)
                {
                    Control[] appoggio = Controls.Find(mostra[i], true);
                    if(appoggio.Length > 0)
                    {
                        panel = (Panel)appoggio[0];
                        if (panel.Visible)
                            panel.Visible = false;
                    }
                }
                aggiornaSezione((Panel)Controls.Find(mostra[app], true)[0], selezionato, padre.Tag.ToString());
            }
            else
                aggiornaSezione(padre, panel, padre.Tag.ToString());
            if (padre.Tag.ToString() != "risultato")
                ((MaterialFlatButton)Controls.Find("visualizza", true)[0]).Visible = false;
        }

        void azioneClick(object sender, EventArgs e)
        {
            Panel padre = new Panel(), panel = new Panel();
            trovaPanelli(ref padre, ref panel, sender);
            int index = mostra.ToList().FindIndex(dato => dato == padre.Name) + 1;
            if(index < mostra.Length)
            {
                cambiaColore(padre, panel);
                Panel principale = (Panel)Controls.Find("Principale", true)[0];
                if (panel.BackColor == Color.Lime)
                {
                    if (Controls.Find(mostra[index], true).Length == 0)
                        creaContenitore(mostra[index], padre.Name, index, panel);
                    else
                        aggiornaSezione(padre, panel, mostra[index]);
                }
                for (int i = 0; i < principale.Controls.Count; i++)
                {
                    if (i <= index)
                        principale.Controls[i].Visible = true;
                    else
                        principale.Controls[i].Visible = false;
                }
                if (panel.BackColor == Color.LightBlue && index < principale.Controls.Count)
                    principale.Controls[index].Visible = false;
            }
            Control[] controls = Controls.Find("esaminandi", true);
            if (controls.Length > 0)
            {
                Panel appoggio = (Panel)controls[0];
                bool vis = false;
                foreach (Control control in appoggio.Controls)
                    if (control.BackColor == Color.Lime)
                        vis = true;
                ((MaterialFlatButton)Controls.Find("visualizza", true)[0]).Visible = vis;
            }
        }

        void azioneBottone(object sender, EventArgs e)
        {
            Panel selezionato = panelSelezionato(4);
            int index = 0;
            Program.query(new MySqlCommand("SELECT * FROM skillcard", Program.connection).ExecuteReader());
            for(int i = 0; i < Program.risQuery.Count; i++)
                if(Program.risQuery[i][Program.risQuery[i].Length - 1] == selezionato.Controls[1].Text)
                {
                    index = i;
                    i = Program.risQuery.Count;
                }
            new SkillCard(false, Program.creaNodo("skillcard", index, "")).ShowDialog();
        }

        Panel panelSelezionato(int index)
        {
            Panel selezionato = new Panel();
            Panel panel = (Panel)Controls.Find(mostra[index], true)[0];
            foreach (Control control in panel.Controls)
                if (control.Controls[0].BackColor == Color.Lime)
                    selezionato = (Panel)control;
            return selezionato;
        }

        void elimina(Nodo selezionato, Panel panel)
        {
            string cond = "";
            DialogResult result = MessageBox.Show("Vuoi eliminare questo campo? ", "ATTENZIONE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(result == DialogResult.OK)
                try
                {
                    cond = " WHERE ";
                    foreach (Campo campo in selezionato.ChiaviPrimarie)
                        cond += campo.nome + " = '" + campo.valore + "' ,";
                    cond = cond.Remove(cond.Length - 2, 2);
                    new MySqlCommand("DELETE FROM " + selezionato.Tabella + cond, Program.connection).ExecuteNonQuery();
                }
                catch
                {
                   result =  MessageBox.Show("Ci sono delle informazioni collegate a questo campo. Vuoi controllare?", "ATTENZIONE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                        new Elimina(selezionato, panel).ShowDialog();
                }
        }

        void cambiaColore(Panel padre, Panel panel)
        {
            if (panel.BackColor == Color.LightBlue)
            {
                foreach (Control control in padre.Controls)
                    if (control.Name != "Titolo" && control.BackColor == Color.Lime)
                        cambiaColoreAiCampi((Panel)control, Color.LightBlue);
                cambiaColoreAiCampi(panel, Color.Lime);
            }
            else
                cambiaColoreAiCampi(panel, Color.LightBlue);
        }

        void cambiaColoreAiCampi(Panel panel, Color color)
        {
            foreach (Control control in panel.Controls)
                control.BackColor = color;
            panel.BackColor = color;
        }

        void trovaPanelli(ref Panel padre, ref Panel panel, object sender)
        {
            try
            {
                panel = (Panel)sender;
                padre = (Panel)Controls.Find(((Panel)sender).Tag.ToString(), true)[0];
            }
            catch
            {
                panel = (Panel)Controls.Find(((Label)sender).Tag.ToString(), true)[0];
                padre = (Panel)Controls.Find(((Label)sender).Name, true)[0];
            }
        }
    }
}
