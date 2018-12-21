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

        string[] mostra;
        Size dimSchermo;
        
        public Principale()
        {
            InitializeComponent();
            mostra = new string[] { "città", "sede", "sessione", "esami", "esaminandi", "risultati" , "skillcard"};
            dimSchermo = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            creaTutto();
        }

        void creaTutto()
        {
            Controls.Add(Program.creaLabel(new Point(dimSchermo.Width / 21 * 10, dimSchermo.Height / 18 * 2), "ESAMI ECDL", "Niente", "Niente"));
            Controls[0].BackColor = Color.White;
            Controls.Add(Program.creaPanel(new Size(dimSchermo.Width, dimSchermo.Height / 6 * 5), new Point(MaximumSize.Width / 12, 140), "Principale", "Principale", Color.White, true));
            ((Panel)Controls.Find("Principale", true)[0]).DoubleClick += azioneDoubleClick;
            ((Panel)Controls.Find("Principale", true)[0]).Click += azioneClick;
            creaContenitore(mostra[0], 0);
        }

        void creaContenitore(string elemento, int pos)
        {
            Panel principale = (Panel)Controls.Find("Principale", true)[0];
            principale.Controls.Add(Program.creaPanel(new Size(dimSchermo.Width / 5, principale.Height), new Point(dimSchermo.Width / 5 * pos), elemento, elemento, Color.LightGray, true));
            ((Panel)principale.Controls[principale.Controls.Count - 1]).BorderStyle = BorderStyle.FixedSingle;
            creaSezione(elemento);
        }

        void creaSezione(string tag)
        {
            Panel principale = (Panel)Controls.Find(tag, true)[0];
            principale.Controls.Add(Program.creaPanel(new Size(principale.Width - 2, principale.Height / 40 * 2), new Point(0, 0), "Titolo", "Titolo", Color.White, false));
            principale.Controls[0].Controls.Add(Program.creaLabel(new Point(principale.Controls[0].Size.Width / 23 * 10, principale.Controls[0].Size.Height / 7), tag , tag, tag));
            Program.query(new MySqlCommand("SELECT COUNT(*) FROM " + tag, Program.connection).ExecuteReader());
            int index = Convert.ToInt32(Program.risQuery[0][0]);
            Program.query(new MySqlCommand("SELECT DISTINCT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = 'esami ecdl' AND TABLE_NAME = '" + tag + "'", Program.connection).ExecuteReader());
            string[] colonne = new string[Program.risQuery.Count];
            for (int i = 0; i < colonne.Length; i++)
                colonne[i] = Program.risQuery[i][0];
            for(int i = 0; i < index; i++)
            {
                int altezza = principale.Controls[0].Location.Y + principale.Controls[0].Size.Height;
                if (principale.Controls.Count > 1)
                    altezza = principale.Controls[principale.Controls.Count - 1].Location.Y + principale.Controls[principale.Controls.Count - 1].Size.Height + 1;
                Panel panel = Program.creaPanel(new Size(principale.Width - 2, principale.Height / 7), new Point(0, altezza), tag + (i + 1).ToString(), tag, Color.LightBlue, false);
                for (int y = 0; y < colonne.Length; y++)
                {
                    Program.query(new MySqlCommand("SELECT " + colonne[y] + " FROM " + tag, Program.connection).ExecuteReader());
                    panel.Controls.Add(Program.creaLabel(new Point(panel.Size.Width / 7, panel.Size.Height / colonne.Length * y), colonne[y] + ":", tag, tag + (i + 1).ToString()));
                    panel.Controls.Add(Program.creaLabel(new Point(panel.Size.Width / 7 * 4, panel.Size.Height / colonne.Length * y), Program.risQuery[i][0], tag, tag + (i + 1).ToString()));
                }
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.DoubleClick += azioneDoubleClick;
                panel.Click += azioneClick;
                foreach (Control control in panel.Controls)
                {
                    control.DoubleClick += azioneDoubleClick;
                    control.Click += azioneClick;
                }
                principale.Controls.Add(panel);
            }
        }

        void aggiornaSezione(Panel padre)
        {
            string tabella = padre.Controls[0].Controls[0].Text;
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
                if(Controls.Find(mostra[index], true).Length == 0)
                    creaContenitore(mostra[index], index);
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

        void elimina()
        {
            string condizione = "";
            DialogResult result = MessageBox.Show("Desideri elimare il campo selezionato", "ATTENZIONE", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                
            }
        }
    }
}
