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

namespace Programma
{
    public partial class Principale : MaterialForm
    {
        //SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'nome del database'
        //Query per prendere il nome delle tabelle di un database

        //SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = 'nome del database'
        //Query per ottenere il nome delle colonne di un database

        //SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE WHERE TABLE_NAME = 'tabella' AND TABLE_SCHEMA = 'database'
        //Query per ottenere il nome delle chiavi primarie di una tabella

        //SELECT ke.REFERENCED_TABLE_SCHEMA parentSchema, ke.referenced_table_name parentTable, ke.REFERENCED_COLUMN_NAME parentColumnName, ke.TABLE_SCHEMA ChildSchema,
        //ke.table_name childTable, ke.COLUMN_NAME ChildColumnName FROM information_schema.KEY_COLUMN_USAGE ke WHERE ke.referenced_table_name IS NOT NULL
        //AND ke.REFERENCED_COLUMN_NAME = 'idCittà'
        //Query per ottenere le tabelle dove è inserita la chiave primaria

        string[] mostra;
        Size dimSchermo;
        
        public Principale()
        {
            InitializeComponent();
            mostra = new string[] { "città", "sede", "sessione", "esami", "esaminandi", "risultati" , "skillcard"};
            dimSchermo = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Program.query(new MySqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'esami ecdl'", Program.connection).ExecuteReader());
            string ciao = Program.risQuery[0][0];
            creaTutto();
        }

        void creaTutto()
        {
            Controls.Add(Program.creaLabel(new Point(dimSchermo.Width / 21 * 10, dimSchermo.Height / 18 * 2), "ESAMI ECDL", "Niente", "Niente"));
            Controls[0].BackColor = Color.White;
            Controls.Add(Program.creaPanel(new Size(dimSchermo.Width, dimSchermo.Height / 6 * 5), new Point(MaximumSize.Width / 12, 140), "Principale", "Principale", Color.White, true));
            ((Panel)Controls.Find("Principale", true)[0]).DoubleClick += azioneDoubleClick;
            ((Panel)Controls.Find("Principale", true)[0]).Click += azioneClick;
            creaContenitore(mostra[0], 0, null);
        }

        void creaContenitore(string elemento, int pos, Panel panel)
        {
            Panel principale = (Panel)Controls.Find("Principale", true)[0];
            principale.Controls.Add(Program.creaPanel(new Size(dimSchermo.Width / 5, principale.Height), new Point(dimSchermo.Width / 5 * pos), elemento, elemento, Color.LightGray, true));
            ((Panel)principale.Controls[principale.Controls.Count - 1]).BorderStyle = BorderStyle.FixedSingle;
            creaSezione(elemento, panel);
        }

        void creaSezione(string tag, Panel panel)
        {
            Panel principale = (Panel)Controls.Find(tag, true)[0];
            principale.Controls.Add(Program.creaPanel(new Size(principale.Width - 2, principale.Height / 40 * 2), new Point(0, 0), "Titolo", "Titolo", Color.White, false));
            principale.Controls[0].Controls.Add(Program.creaLabel(new Point(principale.Controls[0].Size.Width / 23 * 10, principale.Controls[0].Size.Height / 7), tag , tag, tag));
            int index = 3;
            string cond = "";
            condizione(tag, ref index, ref cond, null);
            Program.query(new MySqlCommand("SELECT DISTINCT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = 'esami ecdl' AND TABLE_NAME = '" + tag + "'", Program.connection).ExecuteReader());
            string[] colonne = new string[Program.risQuery.Count];
            for (int i = 0; i < colonne.Length; i++)
                colonne[i] = Program.risQuery[i][0];
            for(int i = 0; i < index; i++)
            {
                int altezza = principale.Controls[0].Location.Y + principale.Controls[0].Size.Height;
                if (principale.Controls.Count > 1)
                    altezza = principale.Controls[principale.Controls.Count - 1].Location.Y + principale.Controls[principale.Controls.Count - 1].Size.Height + 1;
                Panel appoggio = Program.creaPanel(new Size(principale.Width - 2, principale.Height / 12 * 2), new Point(0, altezza), tag + (i + 1).ToString(), tag, Color.LightBlue, false);
                for (int y = 0; y < colonne.Length; y++)
                {
                    Program.query(new MySqlCommand("SELECT " + colonne[y] + " FROM " + tag + cond, Program.connection).ExecuteReader());
                    appoggio.Controls.Add(Program.creaLabel(new Point(appoggio.Size.Width / 7, appoggio.Size.Height / colonne.Length * y), colonne[y] + ":", tag, tag + (i + 1).ToString()));
                    appoggio.Controls.Add(Program.creaLabel(new Point(appoggio.Size.Width / 7 * 4, appoggio.Size.Height / colonne.Length * y), Program.risQuery[i][0], tag, tag + (i + 1).ToString()));
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

        void condizione(string tabella, ref int index, ref string condizione, Panel panel)
        {
            int appoggio = Program.tabelle.ToList().FindIndex(dato => dato == tabella) - 1;
            if (appoggio < 0)
                appoggio = 0;
            List<string> chiavi = Program.chiaviPrimarie(Program.tabelle[index]);
            if(panel != null)
            {
                Program.query(new MySqlCommand("", Program.connection).ExecuteReader());
            }
            else
            {
                Program.query(new MySqlCommand("SELECT COUNT(*) FROM " + tabella, Program.connection).ExecuteReader());
                condizione = "";
                index = Convert.ToInt32(Program.risQuery[0][0]);
            }
        }

        void aggiornaSezione(Panel padre)
        {
            string tabella = padre.Controls[0].Controls[0].Text;
            Program.query(new MySqlCommand("SELECT * FROM " + tabella, Program.connection).ExecuteReader());
            for (int i = 1; i < padre.Controls.Count; i++)
                for (int y = 0, t = 0; y < padre.Controls[i].Controls.Count; y += 2, t++)
                    t = 0;
        }

        void azioneDoubleClick(object sender, EventArgs e)
        {
            Panel padre = new Panel(), panel = new Panel();
            trovaPanelli(ref padre, ref panel, sender);
            List<string> campi = new List<string>();
            if (panel.Name == "Principale")
            {
                panel.BackColor = Color.Lime;
                Program.query(new MySqlCommand("SELECT DISTINCT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = 'esami ecdl' AND TABLE_NAME = '" + panel.Tag.ToString() + "'", 
                                                Program.connection).ExecuteReader());
                foreach (Control control in panel.Controls)
                    if (Program.risQuery[0].Contains(control.Text))
                        campi.Add(control.Text);
            }
            new Messaggio(campi).ShowDialog();
            switch (Program.scelta)
            {
                case "aggiungi": new Modifiche(panel.Tag.ToString()).ShowDialog(); break;
            }
        }

        void azioneClick(object sender, EventArgs e)
        {
            Panel padre = new Panel(), panel = new Panel();
            trovaPanelli(ref padre, ref panel, sender);
            int index = mostra.ToList().FindIndex(dato => dato == padre.Name) + 1;
            if(index < mostra.Length)
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
                Panel principale = (Panel)Controls.Find("Principale", true)[0];
                if (Controls.Find(mostra[index], true).Length == 0)
                    creaContenitore(mostra[index], index, panel);
                else
                    aggiornaSezione(padre);
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
