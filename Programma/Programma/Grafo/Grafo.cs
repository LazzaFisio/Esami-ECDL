using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;

namespace Programma
{
    class Grafo
    {
        List<Nodo> nodos;
        int indexTabella;
        protected MySqlConnection connection;
        List<string> tabelle;
        protected List<string[]> risQuery;

        public Grafo()
        {

        }

        public Grafo(string tabella, int riga, MySqlConnection connection)
        {
            this.connection = connection;
        }

        public Grafo(string connessione, List<string> tabelle)
        {
            nodos = new List<Nodo>();
            indexTabella = 0;
            connection = new MySqlConnection(connessione);
            connection.Open();
            this.tabelle = tabelle;
            caricaGrafo(0);
        }

        public List<Nodo> Nodos { get { return nodos; } }

        public int IndexTabella { get { return indexTabella; } }

        public MySqlConnection SqlConnection { get { return connection; } }

        public void caricaGrafo(int valore)
        {
            List<Nodo> campi = new List<Nodo>();
            query("SELECT COUNT(*) FROM " + tabelle[valore], connection);
            int lenght = Convert.ToInt32(risQuery[0][0]);
            for (int y = 0; y < lenght; y++)
                campi.Add(creaNodo(tabelle[valore], y, connection));
            if (valore == 0)
                foreach (Nodo nodo in campi)
                    nodos.Add(nodo);
            else
                foreach (Nodo item in campi)
                {
                    List<Nodo> nodo = trovaPadre(item, valore);
                    foreach (Nodo item1 in nodo)
                        item1.aggiungiFiglio(item);
                }
            indexTabella++;
        }

        public Nodo creaNodo(string tabella, int index, MySqlConnection connection)
        {
            List<string> chiaviP = trovaChiaviPrimarie(tabella, connection);
            query("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE WHERE TABLE_NAME = '" + tabella + "' AND TABLE_SCHEMA = 'esami ecdl'", connection);
            List<string[]> chiaviE = new List<string[]>();
            foreach (string[] item in risQuery)
                chiaviE.Add(item);
            query("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = 'esami ecdl' AND TABLE_NAME = '" + tabella + "'", connection);
            List<string[]> att = new List<string[]>();
            foreach (string[] item in risQuery)
                att.Add(item);
            query("SELECT * FROM " + tabella, connection);
            List<string> allData = risQuery[index].ToList();
            return new Nodo(tabella, chiaviP, chiaviE, att, allData);
        }

        public List<Nodo> trovaPadre(Nodo nodo, int index)
        {
            List<Nodo> app = new List<Nodo>();
            for (int y = 0; y < nodos.Count; y++)
                padre(nodos[y], nodo, app, index);
            return app;
        }

        void padre(Nodo app, Nodo nodo, List<Nodo> nodoPadre, int index)
        {
            if (app.Tabella != tabelle[index - 1])
                for (int i = 0; i < app.Figli.Count; i++)
                    padre(app.Figli[i], nodo,  nodoPadre, index);
            else if (controllo(app, nodo))
                if(!nodoPadre.Contains(app))
                    nodoPadre.Add(app);
        }

        bool controllo(Nodo app, Nodo nodo)
        {
            bool secondo = false;
            string appoggio = "REFERENCED_COLUMN_NAME = '" + app.ChiaviPrimarie[0].nome + "'";
            query("SELECT table_name, column_name FROM information_schema.KEY_COLUMN_USAGE WHERE referenced_table_name IS NOT NULL AND " + appoggio, connection);
            if (app.ChiaviPrimarie.Count > 1 || !controlloChiave(nodo.Tabella, app.Tabella))
            {
                appoggio = "REFERENCED_COLUMN_NAME = '" + nodo.ChiaviPrimarie[0].nome + "'";
                secondo = true;
            }
            query("SELECT table_name, column_name FROM information_schema.KEY_COLUMN_USAGE WHERE referenced_table_name IS NOT NULL AND " + appoggio, connection);
            foreach (string[] item in risQuery)
                if (item[0] == nodo.Tabella || app.Tabella == item[0])
                {
                    appoggio = appoggio.Split('=')[1];
                    appoggio = appoggio.Remove(0, 2);
                    appoggio = appoggio.Remove(appoggio.Length - 1, 1);
                    if (nodo.ChiaviEsterne.Count > 0)
                    {
                        if (!secondo && funzioneDiControllo(app.ChiaviPrimarie, nodo.ChiaviEsterne, item[1], appoggio))
                            return true;
                        else if (secondo && funzioneDiControllo(app.ChiaviPrimarie, nodo.ChiaviPrimarie, item[1], appoggio))
                            return true;
                        else if (secondo && funzioneDiControllo(app.ChiaviEsterne, nodo.ChiaviPrimarie, appoggio, item[1]))
                            return true;
                    }
                    else if (funzioneDiControllo(app.ChiaviPrimarie, nodo.ChiaviPrimarie, item[1], appoggio))
                        return true;
                }
            return false;
        }

        bool controlloChiave(string tab1, string tab2)
        {
            foreach (string[] item in risQuery)
                if (item[0] == tab1 || item[0] == tab2)
                    return true;
            return false;
        }
             
        bool funzioneDiControllo(List<Campo> app, List<Campo> nodo, string chiaveCampo, string chiaveApp)
        {
            Campo campo = nodo.Find(dato => dato.nome == chiaveCampo);
            Campo campo1 = app.Find(dato => dato.nome == chiaveApp);
            if (campo != null && campo1 != null)
                if (campo.valore == campo1.valore)
                    return true;
            return false;
        }

        public void trovaFigli(Nodo appoggio, Nodo nodo, List<Nodo> lista)
        {
            if (appoggio.Tabella != nodo.Tabella)
                for(int i = 0; i < appoggio.Figli.Count; i++)
                    trovaFigli(appoggio.Figli[i], nodo, lista);
            else if (appoggio.Equals(nodo))
                foreach (Nodo item in appoggio.Figli)
                    if(!lista.Contains(item))
                        lista.Add(item);
        }

        public void aggiungiNodo(string tabella, int index)
        {
            Nodo daAggiungere = creaNodo(tabella, index, connection);
        }

        public void allNodos(List<Nodo> lista)
        {
            foreach(Nodo item in nodos)
                funzione(item ,lista);
        }

        void funzione(Nodo app, List<Nodo> nodos)
        {
            foreach(Nodo item in app.Figli)
            {
                funzione(item, nodos);
                nodos.Add(item);
            }
        }

        public void salvaSuFile()
        {
            StreamWriter writer = new StreamWriter("grafo.txt");
            foreach (Nodo nodo in nodos)
                scrivi(writer, nodo);
            writer.Close();
        }

        void scrivi(StreamWriter writer, Nodo nodo)
        {
            foreach (Nodo item in nodo.Figli)
                scrivi(writer, item);
            daScrivere(writer, nodo.ChiaviPrimarie, "Chiavi primarie");
            daScrivere(writer, nodo.Attributi, "Attributi");
            daScrivere(writer, nodo.ChiaviEsterne, "Chiavi esterne");
            writer.WriteLine("I figli sono: " + nodo.Figli.Count);
            writer.WriteLine("-----------------------------------------------");
        }

        void daScrivere(StreamWriter writer, List<Campo> campos, string titolo)
        {
            writer.WriteLine(titolo);
            foreach (Campo campo in campos)
                writer.WriteLine(campo.inStringa());
            writer.WriteLine();
        }

        void query(string daFare, MySqlConnection connection)
        {
            MySqlDataReader reader = new MySqlCommand(daFare, connection).ExecuteReader();
            risQuery = new List<string[]>();
            while (reader.Read())
            {
                string[] dati = new string[reader.FieldCount];
                for (int i = 0; i < dati.Length; i++)
                    dati[i] = reader.GetValue(i).ToString();
                risQuery.Add(dati);
            }
            reader.Close();
        }

        List<string> trovaChiaviPrimarie(string tabella, MySqlConnection connection)
        {
            List<string> chiavi = new List<string>();
            query("SHOW KEYS FROM " + tabella + " WHERE KEY_NAME = 'Primary'", connection);
            foreach (string[] item in risQuery)
                chiavi.Add(item[4]);
            return chiavi;
        }
    }
}
