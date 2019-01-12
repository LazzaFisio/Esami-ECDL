using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MaterialSkin.Controls;

namespace Programma
{
    class Controllo
    {
        int errore;
        string descriozione;
        string tabella;
        Control.ControlCollection control;

        public Controllo(Control.ControlCollection control, string tabella)
        {
            this.control = control;
            this.tabella = tabella;
            errore = 0;
            descriozione = "";
            new Action(controlloInserimento).Invoke();
        }

        public int Errore { get { return errore; } }

        public string Descriozione { get { return descriozione; } }

        void controlloInserimento()
        {
            List<string[]> data = query("SELECT * FROM " + tabella);
            for(int i = 0; i < data.Count; i++)
            {
                Nodo nodo = Program.creaNodo(tabella, i, "");
                bool doppione = true;
                for(int y = 0; y < nodo.Attributi.Count; y++)
                {
                    MaterialSingleLineTextField label = (MaterialSingleLineTextField)control.Find(nodo.Attributi[y].nome + "-txt", true)[0];
                    if(label.Text != nodo.Attributi[i].valore)
                    {
                        doppione = false;
                        i = nodo.Attributi.Count;
                    }
                }
                if (doppione)
                    caricaErrore(1, "errore inserimento dati");
            }
        }

        void caricaErrore(int num, string err)
        {
            errore = num;
            descriozione = err;
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
