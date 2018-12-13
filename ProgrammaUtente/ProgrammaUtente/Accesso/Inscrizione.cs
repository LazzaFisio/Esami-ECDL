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

namespace ProgrammaUtente.Accesso
{
    public partial class Inscrizione : MaterialForm
    {
        public Inscrizione()
        {
            InitializeComponent();
        }

        private void salva_Click(object sender, EventArgs e)
        {

        }

        private void annulla_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
