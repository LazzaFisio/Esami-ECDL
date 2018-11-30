using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programma
{
    public partial class Principale : Form
    {
        //SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'esami ecdl'
        //Query per prendere il nome delle tabelle di un database

        //SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = 'esami ecdl'
        //Query per ottenere il nome delle colonne di un database


        public Principale()
        {
            InitializeComponent();
        }

        private void leggi_Click(object sender, EventArgs e)
        {
            leggi.BackColor = Color.Lime;
            scrivi.BackColor = Color.Honeydew;
            panelLeggi.Visible = true;
            panelScrivi.Visible = false;
        }

        private void scrivi_Click(object sender, EventArgs e)
        {
            scrivi.BackColor = Color.Lime;
            leggi.BackColor = Color.Honeydew;
            panelScrivi.Visible = true;
            panelLeggi.Visible = false;
        }

        private void azioneComboBox(object sender, EventArgs e)
        {

        }
    }
}
