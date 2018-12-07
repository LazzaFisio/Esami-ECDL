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
            query(new MySqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = '" + Program.database + "'",
                               Program.connection).ExecuteReader());
            foreach (string[] item in dati)
                comboBox.Items.Add(item[0]);
            if(dati.Count > 0)
            {
                comboBox.Text = comboBox.Items[0].ToString();
                azioneComboBox(null, null);
            }
            leggiDatabase();
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
            int index = getIndex();
            if(index > -1)
            {
                List<string> colonne = new List<string>();
                foreach (DataGridViewColumn item in grigliaValori.Columns)
                    colonne.Add(item.HeaderText);
                List<string> campi = new List<string>();
                foreach (DataGridViewCell item in grigliaValori.Rows[index].Cells)
                    campi.Add(item.Value.ToString());
                new Modifiche(colonne, campi, comboBox.Text).Show();
                leggiDatabase();
            }
        }

        private void aggiungi_Click(object sender, EventArgs e)
        {
            List<string> colonne = new List<string>();
            foreach (DataGridViewColumn item in grigliaValori.Columns)
                colonne.Add(item.HeaderText);
            new Modifiche(colonne, comboBox.Text).ShowDialog();
            leggiDatabase();
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
            grigliaValori.Columns.Clear();
            grigliaValori.Rows.Clear();
            query(new MySqlCommand("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = '" + Program.database + "' AND TABLE_NAME = '" + comboBox.Text + "'",
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
            }
        }

        void elimina()
        {
            string condizione = "";
            int index = getIndex();
            if (index > -1)
            {
                DialogResult result = MessageBox.Show("Desideri elimare il campo selezionato", "ATTENZIONE", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                    if (grigliaValori.SelectedCells.Count > 0 || grigliaValori.SelectedRows.Count > 0)
                    {
                        query(new MySqlCommand("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE WHERE TABLE_NAME = '" + comboBox.Text +
                                               "' AND TABLE_SCHEMA = '" + Program.database + "'",
                        Program.connection).ExecuteReader());
                        for (int i = 0; i < dati[0].Length; i++)
                            condizione += dati[0][i] + " = '" + grigliaValori.Rows[0].Cells[i].Value.ToString() + "' AND";
                        condizione = condizione.Remove(condizione.Length - 4, 4);
                        try {
                            new MySqlCommand("DELETE FROM " + comboBox.Text + " WHERE " + condizione).ExecuteNonQuery();
                            leggiDatabase();
                        }catch(Exception err) { MessageBox.Show(err.Message, "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    }
            }
        }

        int getIndex()
        {
            int index = -1;
            if (grigliaValori.SelectedCells.Count == 1)
            {
                if (grigliaValori.SelectedCells[0].RowIndex != grigliaValori.RowCount - 1)
                    index = grigliaValori.SelectedCells[0].RowIndex;
            }
            else if (grigliaValori.SelectedRows.Count == 1)
            {
                index = grigliaValori.SelectedRows[0].Index;
            }
            return index;
        }
    }
}
