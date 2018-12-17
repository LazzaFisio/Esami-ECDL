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

        List<string[]> dati;

        public Principale()
        {
            InitializeComponent();
            dati = new List<string[]>();
            creaTutto();
        }

        private void azioneComboBox(object sender, EventArgs e)
        {
            leggiDatabase();
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
            /*List<string> colonne = new List<string>();
            foreach (DataGridViewColumn item in grigliaValori.Columns)
                colonne.Add(item.HeaderText);
            List<string> campi = new List<string>();
            foreach (DataGridViewCell item in grigliaValori.Rows[index].Cells)
                campi.Add(item.Value.ToString());
            new Modifiche(colonne, campi, chiaviPrimarie(), comboBox.Text).ShowDialog();*/
            leggiDatabase();
        }

        private void aggiungi_Click(object sender, EventArgs e)
        {
           /* List<string> colonne = new List<string>();
            foreach (DataGridViewColumn item in grigliaValori.Columns)
                colonne.Add(item.HeaderText);
            new Modifiche(colonne, comboBox.Text).ShowDialog();*/
            leggiDatabase();
        }

        void creaTutto()
        {
            Size dimSchermo = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Controls.Add(Program.creaBottone(new Point(dimSchermo.Width / 10 * 9, dimSchermo.Height / 10), "modifica", aggiungi_Click));
            Controls.Add(Program.creaLabel(new Point(dimSchermo.Width / 21 * 10, dimSchermo.Height / 18 * 2), "ESAMI ECDL"));
            Controls.Add(Program.creaPanel(new Size(dimSchermo.Width, dimSchermo.Height / 6 * 5), new Point(MaximumSize.Width / 12, 140), "Principale", false));
            Panel principale = (Panel)Controls.Find("Principale", true)[0];
            principale.Controls.Add(Program.creaPanel(new Size(dimSchermo.Width / 5, principale.Height), new Point(0, 0), "1", true));
        }

        void query(MySqlDataReader reader)
        {
            this.dati.Clear();
            while (reader.Read())
            {
                string[] dati = new string[reader.FieldCount];
                for (int i = 0; i < dati.Length; i++)
                    dati[i] = reader.GetValue(i).ToString();
                this.dati.Add(dati);
            }
            reader.Close();
        }

        void leggiDatabase()
        {
            /*query(new MySqlCommand("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = '" + Program.database + "' AND TABLE_NAME = '" + comboBox.Text + "'",
                                   Program.connection).ExecuteReader());
            foreach (string[] item in dati)
            {
                grigliaValori.Columns.Add(item[0], item[0]);
                grigliaValori.Columns[grigliaValori.Columns.Count - 1].ReadOnly = true;
            }
            query(new MySqlCommand("SELECT * FROM " + comboBox.Text, Program.connection).ExecuteReader());
            foreach(string[] item in dati)
            {
                grigliaValori.Rows.Add(item[0]);
                for (int i = 1; i < item.Length; i++)
                    grigliaValori.Rows[grigliaValori.Rows.Count - 2].Cells[i].Value = item[i];
            }*/
        }

        void elimina()
        {
            string condizione = "";
            DialogResult result = MessageBox.Show("Desideri elimare il campo selezionato", "ATTENZIONE", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                /*List<string> chiavi = chiaviPrimarie();
                for (int i = 0; i < grigliaValori.Rows[index].Cells.Count; i++)
                    if (chiavi.Contains(grigliaValori.Columns[i].HeaderText))
                        condizione += grigliaValori.Columns[i].HeaderText + " = '" + grigliaValori.Rows[index].Cells[i].Value.ToString() + "' AND ";*/
                condizione = condizione.Remove(condizione.Length - 4, 4);
                try
                {
                    //new MySqlCommand("DELETE FROM " + comboBox.Text + " WHERE " + condizione, Program.connection).ExecuteNonQuery();
                    leggiDatabase();
                }
                catch (Exception err) { MessageBox.Show(err.Message, "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
        }
    }
}
