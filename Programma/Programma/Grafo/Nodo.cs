using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Programma
{
    class Nodo
    {
        string tabella;
        List<Campo> chiaviPrimarie;
        List<Campo> attributi;
        List<Campo> chiaviEsterne;
        List<Nodo> figli;

        public Nodo()
        {
            tabella = "";
            chiaviPrimarie = new List<Campo>();
            attributi = new List<Campo>();
            chiaviEsterne = new List<Campo>();
            figli = new List<Nodo>();
        }

        public Nodo(string tabella, int riga)
        {
            this.tabella = tabella;
            chiaviPrimarie = new List<Campo>();
            attributi = new List<Campo>();
            chiaviEsterne = new List<Campo>();
            figli = new List<Nodo>();
            //aggiunta nomi dei campi
            List<string> app = Program.chiaviPrimarie(tabella);
            foreach (string item in app)
                chiaviPrimarie.Add(new Campo(item));
            Program.query(new MySqlCommand("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE WHERE TABLE_NAME = '" + tabella + "' AND TABLE_SCHEMA = 'esami ecdl'", Program.connection).ExecuteReader());
            foreach (string[] item in Program.risQuery)
                foreach(Campo campo in chiaviPrimarie)
                    if(campo.nome != item[0])
                    chiaviEsterne.Add(new Campo(item[0]));
            Program.query(new MySqlCommand("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = 'esami ecdl' AND TABLE_NAME = '" + tabella + "'", Program.connection).ExecuteReader());
            foreach (string[] item in Program.risQuery)
                if (!chiaviPrimarie.Exists(dato => dato.nome == item[0]) && !chiaviEsterne.Exists(dato => dato.nome == item[0]))
                    attributi.Add(new Campo(item[0]));
            //aggiunta valori dei campi
            Program.query(new MySqlCommand("SELECT * FROM " + tabella, Program.connection).ExecuteReader());
            app = Program.risQuery[riga].ToList();
            for(int i = 0; i < app.Count; i++)
            {
                if (i < chiaviPrimarie.Count)
                    chiaviPrimarie[i].valore = app[i];
                else if (i - chiaviPrimarie.Count - attributi.Count < 0)
                    attributi[i - chiaviPrimarie.Count].valore = app[i];
                else
                    chiaviEsterne[i - chiaviPrimarie.Count - attributi.Count].valore = app[i];
            }
            if (!controlloChiaviEsterne())
                chiaviEsterne.Clear();
        }

        bool controlloChiaviEsterne()
        {
            foreach (Campo campo in chiaviEsterne)
                if (campo.valore != null)
                    return true;
            return false;
        }

        public void aggiungiFiglio(Nodo figlio) => figli.Add(figlio);

        public string Tabella { get { return tabella; } }

        public List<Campo> ChiaviPrimarie { get { return chiaviPrimarie; } }

        public List<Campo> Attributi { get { return attributi; } }

        public List<Campo> ChiaviEsterne { get { return chiaviEsterne; } }

        public List<Nodo> Figli { get { return figli; } }
    }
}
