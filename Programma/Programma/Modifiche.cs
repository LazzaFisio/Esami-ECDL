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
        public Modifiche(List<string> attributi)
        {
            InitializeComponent();

            dataGridView1.RowCount = attributi.Count + 1;
            for (int i = 0; i < attributi.Count; i++)
                dataGridView1.Rows[i].Cells[0].Value = attributi[i];
        }

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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 1)
                    if (dataGridView1.SelectedRows[0].Index != dataGridView1.RowCount - 1)
                        lblCampoSelezionato.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch
            {
                if (dataGridView1.SelectedCells.Count == 1)
                    if (dataGridView1.SelectedCells[0].RowIndex != dataGridView1.RowCount - 1)
                    {
                        int index = dataGridView1.SelectedCells[0].RowIndex;
                        lblCampoSelezionato.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    }
            }
        }
    }
}
