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
            dataEmissione = DateTime.Today.ToString("yyyy/MM/dd");
            dataScadenza = (DateTime.Today.Year + 1).ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Day.ToString();

            this.Close();
        }

        private void btnMan_Click(object sender, EventArgs e)
        {
            panel3.BringToFront();
        }

        private void btnConfermaCreazione_Click(object sender, EventArgs e)
        {
            string emissione = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            string scadenza = dateTimePicker2.Value.ToString("yyyy/MM/dd");
            if (emissione.CompareTo(scadenza) == -1)
            {
                DialogResult result = MessageBox.Show("Continuare con questi dati?", "Attenzione", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    dataEmissione = emissione;
                    dataScadenza = scadenza;
                    this.Close();
                }
            }
            else
                MessageBox.Show("Dati inseriti non corretti");

            dataEmissione = dataScadenza = "";
        }
    }
}
