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
    public partial class Aggiunta : MaterialForm
    {
        public static string durata = "";

        public Aggiunta(string esame, string sessione)
        {
            InitializeComponent();
            lblEsame.Text = esame;
            lblSessione.Text = sessione;
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Continuare con queste impostazioni?", "Attenzione", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                durata = txtDurata.Text;
                this.Close();
            }
        }
    }
}
