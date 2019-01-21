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
    internal class Controllo
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
            avviaTuttiCotrolli();
        }

        public int Errore { get { return errore; } }

        public string Descriozione { get { return descriozione; } }

        public string InStringa => errore + ": " + descriozione;

        void avviaTuttiCotrolli()
        {
            if(Modifiche.insert)
                controlloInserimento();
            controlloFormattazioneData();
            controlloChiaveEsterna();
        }

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
                    if(label.Text != nodo.Attributi[y].valore)
                    {
                        doppione = false;
                        y = nodo.Attributi.Count;
                    }
                }
                if (doppione)
                    caricaErrore(1, "errore inserimento dati");
            }
        }

        void controlloFormattazioneData()
        {
            MaterialSingleLineTextField field = new MaterialSingleLineTextField();
            Control[] data = control.Find("data-txt", true);
            if (data.Length > 0)
                field = (MaterialSingleLineTextField)data[0];
            else
            {
                data = control.Find("DataNascita-txt", true);
                if(data.Length > 0)
                    field = (MaterialSingleLineTextField)data[0];
            }
            if(field.Name != "")
                try { Convert.ToDateTime(field.Text).ToString("yyyy/MM/dd"); }
                catch { caricaErrore(2, "errore formattazione data"); }
        }

        void controlloChiaveEsterna()
        {
            //cmbEsterna cmbEsterna2(esame)
            List<string> legenda = new List<string>() { "sede:città", "sessione:sede", "esami:sessione:esamesessione", "esaminandi:città/esami:/risultato"};
            Control chiaveEst = control.Find("cmbEsterna", true)[0];
            Control chiaveEst2 = control.Find("cmbEsterna2", true)[0];
            if(control.Find("panel5", true)[0].Visible)
            {
                string[] tabelle = legenda.Find(dato => dato.Split(':')[0] == tabella).Split(':');
                if (tabelle[1].Contains("/"))
                {
                    string[] app = tabelle[1].Split('/');
                    List<string[]> dati = query("SELECT " + Program.chiaviPrimarie(app[0]) + " FROM " + app[0]);
                    string tabellaMM = tabelle[2].Split('/')[1];
                    List<string[]> info = query("SELECT " + Program.chiaviPrimarie(tabellaMM)[0] + " FROM " + tabellaMM);

                }
                else
                {

                }
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
