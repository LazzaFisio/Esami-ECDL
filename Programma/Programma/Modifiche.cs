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
    }
}
