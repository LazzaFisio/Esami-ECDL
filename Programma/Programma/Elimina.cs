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
    public partial class Elimina : MaterialForm
    {
        Nodo nodo;

        public Elimina(Nodo nodo, Panel appoggio)
        {
            InitializeComponent();
            this.nodo = nodo;
            Panel panel = new Panel();
            panel.Size = appoggio.Size;
            panel.Location = new Point(280, 100);
            panel.BackColor = appoggio.BackColor;
            foreach (Control control in appoggio.Controls)
                panel.Controls.Add(Program.creaLabel(control.Location, control.Text, control.Text, control.Tag.ToString()));
            Controls.Add(panel);
        }
    }
}
