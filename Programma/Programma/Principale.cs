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

namespace Programma
{
    public partial class Principale : Form
    {
        //SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'nome del database'
        //Query per prendere il nome delle tabelle di un database

        //SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = 'nome del database'
        //Query per ottenere il nome delle colonne di un database

        List<string[]> dati;

        public Principale()
        {
            InitializeComponent();
            dati = new List<string[]>();
            query(new MySqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = '" + Program.database + "'",
                               Program.connection).ExecuteReader());
            foreach (string[] item in dati)
                comboBox.Items.Add(item[0]);
            if(dati.Count > 0)
            {
                comboBox.Text = comboBox.Items[0].ToString();
                azioneComboBox(null, null);
            }
        }

        private void leggi_Click(object sender, EventArgs e)
        {
            leggi.BackColor = Color.Lime;
            scrivi.BackColor = Color.Honeydew;
            panelLeggi.Visible = true;
            panelScrivi.Visible = false;
        }

        private void scrivi_Click(object sender, EventArgs e)
        {
            scrivi.BackColor = Color.Lime;
            leggi.BackColor = Color.Honeydew;
            panelScrivi.Visible = true;
            panelLeggi.Visible = false;
        }

        private void azioneComboBox(object sender, EventArgs e)
        {
            if (leggi.BackColor == Color.Lime)
                leggiDatabase();
        }

        private void elimina(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Desideri elimare questo campo");
        }

        private void scelta(object sender, DataGridViewCellEventArgs e)
        {

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
            grigliaLeggi.Columns.Clear();
            grigliaLeggi.Rows.Clear();
            query(new MySqlCommand("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = '" + Program.database + "' AND TABLE_NAME = '" + comboBox.Text + "'",
                                   Program.connection).ExecuteReader());
            foreach (string[] item in dati)
            {
                grigliaLeggi.Columns.Add(item[0], item[0]);
                grigliaLeggi.Columns[grigliaLeggi.Columns.Count - 1].ReadOnly = true;
            }
            query(new MySqlCommand("SELECT * FROM " + comboBox.Text, Program.connection).ExecuteReader());
            foreach(string[] item in dati)
            {
                grigliaLeggi.Rows.Add(item[0]);
                for (int i = 1; i < item.Length; i++)
                    grigliaLeggi.Rows[grigliaLeggi.Rows.Count - 1].Cells[i].Value = item[i];
            }
        }
    }
}
