using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Programma
{
    class Controllo
    {
        int errore;
        string tabella;
        Control.ControlCollection control;

        public Controllo(Control.ControlCollection control, string tabella)
        {
            this.control = control;
            this.tabella = tabella;
            errore = 0;
            controlloGenerale();
        }

        public int Errore { get { return errore; } }

        void controlloGenerale()
        {
            
        }

        void controlloInserimento()
        {
            List<string[]> data = query("SELECT * FROM " + tabella);
            for(int i = 0; i < data.Count; i++)
            {
                Nodo nodo = Program.creaNodo(tabella, i, "");
                bool doppione = true;
                for(int y = 0; y < nodo.Attributi.Count; i++)
                {
                    
                }
                if (doppione)
                    errore = 1;
            }
        }

        List<string[]> query(string query)
        {
            List<string[]> vs = new List<string[]>();
            Program.query(new MySqlCommand(query, Program.connection).ExecuteReader());
            foreach (string[] item in Program.risQuery)
                vs.Add(item);
            return vs;
        }

    }
}
