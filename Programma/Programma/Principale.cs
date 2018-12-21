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
            mostra = new string[] { "città", "sede", "sessione", "esami", "risultati", "esaminandi" };
            dimSchermo = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            creaTutto();
        }

        private void elimina(object sender, DataGridViewCellEventArgs e)
        {
            elimina();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            elimina();
        }

        private void modica_Click(object sender, EventArgs e)
        {

        }

        private void aggiungi_Click(object sender, EventArgs e)
        {
          
        }

        void creaTutto()
        {
            Controls.Add(Program.creaBottone(new Point(dimSchermo.Width / 10 * 9, dimSchermo.Height / 10), "modifica", modica_Click));
            Controls.Add(Program.creaBottone(new Point(dimSchermo.Width / 10 * 8, dimSchermo.Height / 10), "aggiungi", aggiungi_Click));
            Controls.Add(Program.creaLabel(new Point(dimSchermo.Width / 21 * 10, dimSchermo.Height / 18 * 2), "ESAMI ECDL", "Nientes"));
            Controls[Controls.Count - 1].BackColor = Color.White;
            Controls.Add(Program.creaPanel(new Size(dimSchermo.Width, dimSchermo.Height / 6 * 5), new Point(MaximumSize.Width / 12, 140), "Principale", Color.White, true));
            creaContenitore(mostra[0], 0);
        }

        void creaContenitore(string elemento, int pos)
        {
            Panel principale = (Panel)Controls.Find("Principale", true)[0];
            principale.Controls.Add(Program.creaPanel(new Size(dimSchermo.Width / 5, principale.Height), new Point(dimSchermo.Width / 5 * pos), elemento, Color.White, true));
            creaSezione(elemento);
        }

        void creaSezione(string tag)
        {
            Panel principale = (Panel)Controls.Find(tag, true)[0];
            principale.Controls.Add(Program.creaPanel(new Size(principale.Width, principale.Height / 40), new Point(0, 0), "Titolo", Color.White, false));
            principale.Controls[0].Controls.Add(Program.creaLabel(new Point(principale.Controls[0].Size.Width / 23 * 10, principale.Controls[0].Size.Height / 7), tag , tag));
            Program.query(new MySqlCommand("SELECT COUNT(*) FROM " + tag, Program.connection).ExecuteReader());
            int index = Convert.ToInt32(Program.risQuery[0][0]);
            Program.query(new MySqlCommand("SELECT DISTINCT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = 'esami ecdl' AND TABLE_NAME = '" + tag + "'", Program.connection).ExecuteReader());
            string[] colonne = new string[Program.risQuery.Count];
            for (int i = 0; i < colonne.Length; i++)
                colonne[i] = Program.risQuery[i][0];
            for(int i = 0; i < index; i++)
            {
                int altezza = principale.Height / 40 + principale.Controls[0].Size.Height;
                if (principale.Controls.Count > 1)
                    altezza = principale.Controls[principale.Controls.Count - 1].Height + principale.Controls[principale.Controls.Count - 1].Size.Height / 3 + 3;
                Panel panel = Program.creaPanel(new Size(principale.Width, principale.Height / 7), new Point(0, altezza), (i + 1).ToString(), Color.LightBlue, false);
                for (int y = 0; y < colonne.Length; y++)
                {
                    Program.query(new MySqlCommand("SELECT " + colonne[y] + " FROM " + tag, Program.connection).ExecuteReader());
                    panel.Controls.Add(Program.creaLabel(new Point(panel.Size.Width / 7, panel.Size.Height / colonne.Length * y), colonne[y] + ":", tag));
                    panel.Controls.Add(Program.creaLabel(new Point(panel.Size.Width / 7 * 4, panel.Size.Height / colonne.Length * y), Program.risQuery[i][0], tag));
                }
                panel.BorderStyle = BorderStyle.FixedSingle;
                foreach (Control control in panel.Controls)
                    control.Click += azione;
                principale.Controls.Add(panel);
            }
        }

        void azione(object sender, EventArgs e)
        {
            
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
