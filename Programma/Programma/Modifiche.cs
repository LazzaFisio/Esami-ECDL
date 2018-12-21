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
        string tabella;

        public Modifiche(string tabella)
        {
            InitializeComponent();
            this.tabella = tabella;
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();

            if (rbNuovo.Checked)
                panel1.Show();
            else
                panel2.Show();
        }

        private void Aggiorna()
        {
            Program.query(new MySqlCommand("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = '" + tabella + "'", Program.connection).ExecuteReader());
            List<string[]> campi = Program.risQuery;

            List<string> primary = Program.chiaviPrimarie(tabella);

            
        }
    }
}