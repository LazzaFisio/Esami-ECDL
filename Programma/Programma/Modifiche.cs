using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;

namespace Programma
{
    public partial class Modifiche : MaterialForm
    {
        int index = int.MaxValue;
        bool insert = false;
        string tabella = "";
        List<string> primarykey = new List<string>();

        /// <summary>
        /// Costruttore con passaggio della lista degli attributi della tabella
        /// </summary>
        /// <param name="attributi"> Lista di attributi della tabella</param>
        public Modifiche(List<string> attributi, string tabella)
        {
            InitializeComponent();

            dataGridView1.RowCount = attributi.Count;
            for (int i = 0; i < attributi.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = attributi[i];
                dataGridView1.Rows[i].Cells[1].Value = "";
            }
            insert = true;
            this.tabella = tabella;
        }

        /// <summary>
        /// Costruttore con passaggio della lista degli attributi e dei relativi campi
        /// </summary>
        /// <param name="attributi">Lista degli attributi del database</param>
        /// <param name="campi">Lista dei campi della tabella</param>
        public Modifiche(List<string> attributi, List<string> campi,List<string> primary, string tabella)
        {
            InitializeComponent();

            dataGridView1.RowCount = attributi.Count;
            for (int i = 0; i < attributi.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = attributi[i];
                dataGridView1.Rows[i].Cells[1].Value = campi[i];
            }
            insert = false;
            this.tabella = tabella;
            primarykey = primary;
        }

        /// <summary>
        /// Funzione di modifica delle label in base alla riga selezionata
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //&& dataGridView1.SelectedCells[0].RowIndex != dataGridView1.RowCount - 1
            if (dataGridView1.SelectedCells.Count == 1 )
                    index = dataGridView1.SelectedCells[0].RowIndex;
            else if (dataGridView1.SelectedRows.Count == 1 )
                    index = dataGridView1.SelectedRows[0].Index;

            if (index != int.MaxValue)
            {
                lblCampoSelezionato.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                txtNuovoCampo.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            }
        }

        /// <summary>
        /// Evento generato dal text change della text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNuovoCampo_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows[index].Cells[1].Value = txtNuovoCampo.Text;
        }

        /// <summary>
        /// funzione che si verifica quando viene premuto il bottone
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Conferma_Click(object sender, EventArgs e)
        {
            string query = "";
            if (insert)
            {
                query = "INSERT INTO " + tabella + "( ";
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    query += dataGridView1.Rows[i].Cells[0].Value.ToString() + ", ";
                query = query.Remove(query.Length - 2, 1);
                query += ") VALUES ( '";
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    query += dataGridView1.Rows[i].Cells[1].Value.ToString() + "', '";
                query = query.Remove(query.Length - 4, 3);
                query += ")";
            }
            else
            { 
                int[] app = new int[primarykey.Count];
                for (int i = 0; i < primarykey.Count; i++)
                    for (int j = 0; j < dataGridView1.Rows.Count; j++)
                        if (dataGridView1.Rows[j].Cells[0].Value.ToString() == primarykey[i])
                            app[i] = j;

                query = "UPDATE " + tabella + " SET ";
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    if (!app.Contains(i))
                        query += dataGridView1.Rows[i].Cells[0].Value.ToString() + " = '" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "', ";
                query = query.Remove(query.Length - 2, 1);
                query += " WHERE ";

                for (int i = 0; i < app.Length; i++)
                    query += dataGridView1.Rows[app[i]].Cells[0].Value.ToString() + " = '" + dataGridView1.Rows[app[i]].Cells[1].Value.ToString() + "', ";
                query = query.Remove(query.Length - 2, 1);
                query += ";";
            }
            try { new MySqlCommand(query, Program.connection).ExecuteNonQuery(); this.Close(); }
            catch (Exception err) { MessageBox.Show(err.Message, "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
    }
}
