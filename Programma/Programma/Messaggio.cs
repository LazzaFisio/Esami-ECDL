using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using MaterialSkin.Animations;

namespace Programma
{
    public partial class Messaggio : MaterialForm
    {

        public Messaggio(string tabella, List<string> campi)
        {
            InitializeComponent();
            if (campi.Count == 0)
                modifica.Enabled = elimina.Enabled = false;
            if (tabella == "risultato")
                elimina.Enabled = aggiungi.Enabled = false;
        }

        private void aggiungi_Click(object sender, EventArgs e)
        {
            Program.scelta = "aggiungi";
            Close();
        }

        private void modifica_Click(object sender, EventArgs e)
        {
            Program.scelta = "modifica";
            Close();
        }

        private void elimina_Click(object sender, EventArgs e)
        {
            Program.scelta = "elimina";
            Close();
        }
    }
}
