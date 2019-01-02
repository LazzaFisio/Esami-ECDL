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
            salvaSuFile();
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
                        Nodo padre = new Nodo();
                        for (int y = 0; y < nodos.Count && padre.Tabella == ""; y++)
                            trovaPadre(nodos[y], item, ref padre, i);
                        padre.aggiungiFiglio(item);
                    }
                Program.progressBar.Increment(1);
            }
        }

        void trovaPadre(Nodo app, Nodo nodo, ref Nodo padre, int index)
        {
            if (app.Tabella != Program.tabelle[index - 1])
                for(int i = 0; i < app.Figli.Count && padre.Tabella == ""; i++)
                    trovaPadre(app.Figli[i], nodo, ref padre, index);
            if (controllo(app, nodo))
                padre = app;
        }

        bool controllo(Nodo app, Nodo nodo)
        {
            string appoggio = "REFERENCED_COLUMN_NAME = '" + app.ChiaviPrimarie[0].nome + "'";
            if (app.ChiaviPrimarie.Count > 1)
                appoggio = "REFERENCED_COLUMN_NAME = '" + nodo.ChiaviPrimarie[0].nome + "'";
            Program.query(new MySqlCommand("SELECT table_name, column_name FROM information_schema.KEY_COLUMN_USAGE WHERE referenced_table_name IS NOT NULL AND " + appoggio, Program.connection).ExecuteReader());
            foreach (string[] item in Program.risQuery)
                if (item[0] == nodo.Tabella || app.Tabella == item[0])
                {
                    appoggio = appoggio.Split('=')[1];
                    appoggio = appoggio.Remove(0, 2);
                    appoggio = appoggio.Remove(appoggio.Length - 1, 1);
                    if (nodo.ChiaviEsterne.Count > 0)
                    {
                        if (funzioneDiControllo(app.ChiaviPrimarie, nodo.ChiaviEsterne, item[1], appoggio))
                            return true;
                    }
                    else if (funzioneDiControllo(app.ChiaviPrimarie, nodo.ChiaviPrimarie, item[1], appoggio))
                        return true;
                }
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
