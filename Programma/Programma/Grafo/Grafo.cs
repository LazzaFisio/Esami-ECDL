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
            Program.query(new MySqlCommand("SELECT COUNT(*) FROM " + Program.tabelle[0], Program.connection).ExecuteReader());
            int lenght = Convert.ToInt32(Program.risQuery[0][0]);
            for (int i = 0; i < lenght; i++)
                nodos.Add(new Nodo(Program.tabelle[0], i));
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
            if (nodo.Figlio != null)
                scrivi(writer, nodo.Figlio);
            daScrivere(writer, nodo.ChiaviPrimarie, "Chiavi primarie");
            daScrivere(writer, nodo.Attributi, "Attributi");
            daScrivere(writer, nodo.ChiaviEsterne, "Chiavi esterne");
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
