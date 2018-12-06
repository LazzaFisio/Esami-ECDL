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

namespace Programma
{
    public partial class Modifiche : MaterialForm
    {
        int index = 0;

        /// <summary>
        /// Costruttore con passaggio della lista degli attributi della tabella
        /// </summary>
        /// <param name="attributi"> Lista di attributi della tabella</param>
        public Modifiche(List<string> attributi)
        {
            InitializeComponent();

            dataGridView1.RowCount = attributi.Count + 1;
            for (int i = 0; i < attributi.Count; i++)
                dataGridView1.Rows[i].Cells[0].Value = attributi[i];
        }

        /// <summary>
        /// Costruttore con passaggio della lista degli attributi e dei relativi campi
        /// </summary>
        /// <param name="attributi">Lista degli attributi del database</param>
        /// <param name="campi">Lista dei campi della tabella</param>
        public Modifiche(List<string> attributi, List<string> campi)
        {
            InitializeComponent();

            dataGridView1.RowCount = attributi.Count + 1;
            for (int i = 0; i < attributi.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = attributi[i];
                dataGridView1.Rows[i].Cells[1].Value = campi[i];
            }
        }

        /// <summary>
        /// Funzione di modifica delle label in base alla riga selezionata
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 1)
            {
                if (dataGridView1.SelectedCells[0].RowIndex != dataGridView1.RowCount - 1)
                    index = dataGridView1.SelectedCells[0].RowIndex;
            }
            else if (dataGridView1.SelectedRows.Count == 1)
            {
                index = dataGridView1.SelectedRows[0].Index;
            }
            try
            {
                if (dataGridView1.SelectedRows.Count == 1)
                    if (dataGridView1.SelectedRows[0].Index != dataGridView1.RowCount - 1)
                    {
                        lblCampoSelezionato.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        lblValoreAttuale.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    }
            }
            catch
            {
                if (dataGridView1.SelectedCells.Count == 1)
                    if (dataGridView1.SelectedCells[0].RowIndex != dataGridView1.RowCount - 1)
                    {
                        index = dataGridView1.SelectedCells[0].RowIndex;
                        lblCampoSelezionato.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                        lblValoreAttuale.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    }
            }
        }

        private void btnConfModifica_Click(object sender, EventArgs e)
        {

        }
    }
}
