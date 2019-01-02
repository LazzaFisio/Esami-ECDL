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
            mostra = new string[] { "città", "sede", "sessione", "esami", "esaminandi", "skillcard", "risultato" };
            Program.query(new MySqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'esami ecdl'", Program.connection).ExecuteReader());
            creaTutto();
        }

        void creaTutto()
        {
            Controls.Add(Program.creaLabel(new Point(dimSchermo.Width / 21 * 10, dimSchermo.Height / 20 * 2), "ESAMI ECDL", "Niente", "Niente"));
            Controls[0].BackColor = Color.White;
            Controls.Add(Program.creaPanel(new Size(dimSchermo.Width, dimSchermo.Height / 6 * 5), new Point(MaximumSize.Width / 12, 140), "Principale", "Principale", Color.White, true));
            creaContenitore(Program.tabelle[0], "", 0, null);
        }

        void creaContenitore(string elemento, string tabPrec, int pos, Panel panel)
        {
            Panel principale = (Panel)Controls.Find("Principale", true)[0];
            principale.Controls.Add(Program.creaPanel(new Size(dimSchermo.Width / 5, principale.Height), new Point(dimSchermo.Width / 5 * pos), elemento, elemento, Color.LightGray, true));
            ((Panel)principale.Controls[principale.Controls.Count - 1]).BorderStyle = BorderStyle.FixedSingle;
            ((Panel)principale.Controls[principale.Controls.Count - 1]).DoubleClick += azioneDoubleClick;
            creaSezione(elemento, tabPrec, panel);
        }

        void creaSezione(string tag, string tabPrec, Panel panel)
        {
            Panel principale = (Panel)Controls.Find(tag, true)[0];
            principale.Controls.Add(Program.creaPanel(new Size(principale.Width - 4, principale.Height / 40 * 2), new Point(0, 0), "Titolo", "Titolo", Color.White, false));
            principale.Controls[0].Controls.Add(Program.creaLabel(new Point(principale.Controls[0].Size.Width / 23 * 10, principale.Controls[0].Size.Height / 7), tag , tag, tag));
            List<Nodo> daInserire = new List<Nodo>();
            if (tag == "città")
                foreach (Nodo nodo in Program.grafo.Nodos)
                    daInserire.Add(nodo);
            else
            {
                Nodo nodo = creaNodo(tabPrec, panel);
                for (int i = 0; i < Program.grafo.Nodos.Count && daInserire.Count == 0; i++)
                    Program.grafo.trovaFigli(Program.grafo.Nodos[i], nodo, daInserire);
            }
            Program.query(new MySqlCommand("SELECT DISTINCT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = 'esami ecdl' AND TABLE_NAME = '" + tag + "'", Program.connection).ExecuteReader());
            string[] colonne = new string[Program.risQuery.Count];
            for (int i = 0; i < colonne.Length; i++)
                colonne[i] = Program.risQuery[i][0];
            for(int i = 0; i < daInserire.Count; i++)
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
        }

        Nodo creaNodo(string tabella, Panel panel)
        {
            int index = -1;
            string appoggio = "";
            List<string> chiavi = Program.chiaviPrimarie(tabella);
            foreach (string item in chiavi)
                appoggio += item + ", ";
            appoggio = appoggio.Remove(appoggio.Length - 2, 2);
            Program.query(new MySqlCommand("SELECT " + appoggio + " FROM " + tabella, Program.connection).ExecuteReader());
            for(int i = 0; i < Program.risQuery.Count; i++)
                if(controlloNodo(Program.risQuery[i], chiavi.ToArray(), panel))
                {
                    index = i;
                    i = Program.risQuery.Count;
                }
            return new Nodo(tabella, index);
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

        void aggiornaSezione(Panel padre, Panel selezionato)
        {
            string tabella = Program.tabelle[Program.tabelle.ToList().FindIndex(dato => dato == padre.Controls[0].Controls[0].Text) + 1];
            Panel panel = (Panel)Controls.Find(tabella, true)[0];
            panel.Controls.Clear();
            creaSezione(tabella,padre.Name, selezionato);
        }

        void azioneDoubleClick(object sender, EventArgs e)
        {
            Panel padre = new Panel(), panel = new Panel();
            trovaPanelli(ref padre, ref panel, sender);
            if (padre.Name != panel.Name)
                cambiaColore(padre, panel);
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
            new Messaggio(campi).ShowDialog();
            switch (Program.scelta)
            {
                case "aggiungi": new Modifiche(panel.Tag.ToString()).ShowDialog(); break;
            }
            Program.scelta = "";
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
                        aggiornaSezione(padre, panel);
                }
                for (int i = 0; i < principale.Controls.Count; i++)
                {
                    if (i <= index)
                        principale.Controls[i].Visible = true;
                    else
                        principale.Controls[i].Visible = false;
                }
                if (panel.BackColor == Color.LightBlue)
                    principale.Controls[index].Visible = false;
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
