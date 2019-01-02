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

        public Grafo()
        {
            nodos = new List<Nodo>();
            Program.progressBar.Value = 0;
            caricaGrafo();
        }

        public List<Nodo> Nodos { get { return nodos; } }

        void caricaGrafo()
        {
            for(int i = 0; i < Program.tabelle.Length; i++)
            {
                List<Nodo> campi = new List<Nodo>();
                Program.query(new MySqlCommand("SELECT COUNT(*) FROM " + Program.tabelle[i], Program.connection).ExecuteReader());
                int lenght = Convert.ToInt32(Program.risQuery[0][0]);
                for (int y = 0; y < lenght; y++)
                    campi.Add(new Nodo(Program.tabelle[i], y));
                if (i == 0)
                    foreach (Nodo nodo in campi)
                        nodos.Add(nodo);
                else
                    foreach(Nodo item in campi)
                    {
                        Nodo nodo = trovaPadre(item, i);
                        nodo.aggiungiFiglio(item);
                    }
                Program.progressBar.Increment(1);
            }
        }

        public Nodo trovaPadre(Nodo nodo, int index)
        {
            Nodo app = new Nodo();
            for (int y = 0; y < nodos.Count && app.Tabella == ""; y++)
                padre(nodos[y], nodo, ref app, index);
            return app;
        }

        void padre(Nodo app, Nodo nodo, ref Nodo nodoPadre, int index)
        {
            if (app.Tabella != Program.tabelle[index - 1])
                for (int i = 0; i < app.Figli.Count && nodoPadre.Tabella == ""; i++)
                    padre(app.Figli[i], nodo, ref nodoPadre, index);
            else if (controllo(app, nodo) && nodoPadre.Tabella == "")
                nodoPadre = app;
        }

        bool controllo(Nodo app, Nodo nodo)
        {
            bool secondo = false;
            string appoggio = "REFERENCED_COLUMN_NAME = '" + app.ChiaviPrimarie[0].nome + "'";
            Program.query(new MySqlCommand("SELECT table_name, column_name FROM information_schema.KEY_COLUMN_USAGE WHERE referenced_table_name IS NOT NULL AND " + appoggio, Program.connection).ExecuteReader());
            if (app.ChiaviPrimarie.Count > 1 || !controlloChiave(nodo.Tabella, app.Tabella))
            {
                appoggio = "REFERENCED_COLUMN_NAME = '" + nodo.ChiaviPrimarie[0].nome + "'";
                secondo = true;
            }
            Program.query(new MySqlCommand("SELECT table_name, column_name FROM information_schema.KEY_COLUMN_USAGE WHERE referenced_table_name IS NOT NULL AND " + appoggio, Program.connection).ExecuteReader());
            foreach (string[] item in Program.risQuery)
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
            foreach (string[] item in Program.risQuery)
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
            if (appoggio.Tabella != nodo.Tabella && lista.Count == 0)
                for(int i = 0; i < appoggio.Figli.Count && lista.Count == 0; i++)
                    trovaFigli(appoggio.Figli[i], nodo, lista);
            else if (appoggio.Equals(nodo))
                foreach (Nodo item in appoggio.Figli)
                    lista.Add(item);
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
    }
}
