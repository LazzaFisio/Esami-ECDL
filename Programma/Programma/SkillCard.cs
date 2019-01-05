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
    public partial class SkillCard : MaterialForm
    {
        public static string dataEmissione;
        public static string dataScadenza;

        public SkillCard()
        {
            InitializeComponent();
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            dataEmissione = DateTime.Today.ToString();
            dataScadenza = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + (DateTime.Today.Year + 1).ToString();

            this.Close();
        }

        private void btnMan_Click(object sender, EventArgs e)
        {
            panel3.BringToFront();
        }

        private void btnConfermaCreazione_Click(object sender, EventArgs e)
        {
            if (txtEmissione.Text.CompareTo(txtScadenza.Text) == -1)
            {
                DialogResult result = MessageBox.Show("Continuare con questi dati?", "Attenzione", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    dataEmissione = txtEmissione.Text;
                    dataScadenza = txtScadenza.Text;

                    this.Close();
                }
            }
            else
                MessageBox.Show("Dati inseriti non corretti");
        }
    }
}
