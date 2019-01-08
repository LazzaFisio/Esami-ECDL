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
using MySql.Data.MySqlClient;

namespace Programma
{
    public partial class Elimina : MaterialForm
    {
        Nodo nodo;
        List<DataGridView> dataGridViews = new List<DataGridView>();

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

        void caricaDati(Nodo nodo)
        {
            List<Nodo> nodos = new List<Nodo>() { nodo};
            List<Nodo> valori = new List<Nodo>();
            controllo(nodos, valori);
            while(valori.Count > 0)
            {

            }
        }

        void controllo(List<Nodo> nodos, List<Nodo> valori)
        {
            foreach(Nodo item in nodos)
            {
                string cond = "";
                foreach (Campo item1 in item.ChiaviPrimarie)
                    cond += "REFERENCED_COLUMN_NAME = '" + item1.nome + "' ,";
                cond = cond.Remove(cond.Length - 2, 2);
                Program.query(new MySqlCommand("SELECT table_name, column_name FROM information_schema.KEY_COLUMN_USAGE WHERE referenced_table_name IS NOT NULL AND " + cond, Program.connection).ExecuteReader());
                List<string[]> ris = new List<string[]>();
                foreach (string[] item1 in Program.risQuery)
                    ris.Add(item1);
                foreach (string[] item1 in ris)
                {
                    cond = " WHERE ";
                    foreach (Campo item2 in item.ChiaviPrimarie)
                        cond += item1[1] + " = '" + item2.valore + "' ,";
                    cond = cond.Remove(cond.Length - 2, 2);
                    Program.query(new MySqlCommand("SELECT * FROM " + item1[0] + cond, Program.connection).ExecuteReader());
                    List<string[]> ris1 = new List<string[]>();
                    foreach (string[] item2 in Program.risQuery)
                        ris1.Add(item2);
                    for (int i = 0; i < ris1.Count; i++)
                        valori.Add(Program.creaNodo(item1[0], i, cond));
                }
            }
        }
    }
}
