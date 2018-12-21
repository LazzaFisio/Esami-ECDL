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
        List<string> padri = new List<string>();
        List<string> esistenti = new List<string>();

        public Modifiche(string tabella, List<string> padri, List<string> esistenti)
        {
            InitializeComponent();
            this.tabella = tabella;
            this.padri = padri;
            this.esistenti = esistenti;
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

        private void Aggiorna(List<string> padri, List<string> esistenti)
        {
            if (padri.Count != 0)
                foreach (string item in padri)
                    cmb1.Items.Add(item);
            else
                cmb1.Enabled = false;

            foreach (string item in esistenti)
                cmbEsistente.Items.Add(item);

            Program.query(new MySqlCommand("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = '" + tabella + "'", Program.connection).ExecuteReader());
            List<string[]> campi = Program.risQuery;

            
            
        }
    }
}