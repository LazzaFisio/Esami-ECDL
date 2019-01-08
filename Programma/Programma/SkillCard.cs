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

        public SkillCard(bool cond, Nodo nodo)
        {
            InitializeComponent();
            btnConfermaCreazione.Enabled = cond;
            aggiungiData(dateTimePicker1, nodo, 0);
            aggiungiData(dateTimePicker2, nodo, 1);
            panel3.BringToFront();
        }

        void aggiungiData(DateTimePicker date, Nodo nodo , int index)
        {
            string[] data = nodo.Attributi[index].valore.Split('/');
            data[2] = data[2].Split(' ')[0];
            date.Value = new DateTime(Convert.ToInt32(data[2]), Convert.ToInt32(data[1]), Convert.ToInt32(data[0]));
            date.Enabled = false;
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
