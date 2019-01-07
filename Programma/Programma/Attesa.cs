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

namespace Programma
{
    public partial class Attesa : MaterialForm
    {
        int index;

        public Attesa(int index, string elementi)
        {
            InitializeComponent();
            this.index = index;
            timer1.Interval = Convert.ToInt32(elementi) * 20;
            timer1.Start();
        }

        public Attesa(int index)
        {
            InitializeComponent();
            this.index = index;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            //while (index >= Program.grafo.IndexTabella) ;
            Close();
        }
    }
}
