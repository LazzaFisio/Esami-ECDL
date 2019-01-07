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
    public partial class Dettagli : MaterialForm
    {
        public static string durata;

        public Dettagli(string sessione, string esame)
        {            
            InitializeComponent();
            lblSessione.Text = sessione;
            lblEsame.Text = esame;
        }

        private void btnConf_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sei sicuro di voler inserire questa durata?", "Attenzione", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                durata = txtDurata.Text;
                this.Close();
            }
        }
    }
}
