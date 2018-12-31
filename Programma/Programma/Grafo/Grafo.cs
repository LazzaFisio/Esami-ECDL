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
        public List<Nodo> nodos;

        public Grafo()
        {
            nodos = new List<Nodo>();
            caricaGrafo();
            salvaSuFile();
        }

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
            }
        }

        void trovaPadre(Nodo app, Nodo nodo, ref Nodo padre, int index)
        {
            if (app.Tabella != Program.tabelle[index - 1])
                for(int i = 0; i < app.Figli.Count && padre.Tabella == ""; i++)
                    trovaPadre(app.Figli[i], nodo, ref padre, index);
            if (nodo.ChiaviEsterne.Count > 0 && controllo(app, nodo))
                padre = app;
            else if (controlloNoFK(app, nodo))
                padre = app;
        }

        bool controllo(Nodo app, Nodo nodo)
        {
            string appoggio = "";
            foreach (Campo campo in app.ChiaviPrimarie)
                appoggio += "REFERENCED_COLUMN_NAME = '" + campo.nome + "' AND";
            appoggio = appoggio.Remove(appoggio.Length - 4, 4);
            Program.query(new MySqlCommand("SELECT table_name, column_name FROM information_schema.KEY_COLUMN_USAGE WHERE referenced_table_name IS NOT NULL AND " + appoggio, Program.connection).ExecuteReader());
            foreach (string[] item in Program.risQuery)
                if (item[0] == nodo.Tabella && nodo.ChiaviEsterne.Exists(dato => dato.nome == item[1]))
                    for (int i = 0; i < nodo.ChiaviEsterne.Count; i++)
                        if (nodo.ChiaviEsterne[i].valore == app.ChiaviPrimarie[i].valore)
                            return true;
            return false;
        }

        bool controlloNoFK(Nodo app, Nodo nodo)
        {
            return false;
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
