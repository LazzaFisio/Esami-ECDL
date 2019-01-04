using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Programma
{
    [Serializable()]
    public class Nodo : IEquatable<Nodo>
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

        /* public Nodo(SerializationInfo info, StreamingContext context)
        {
            int dim = 0;
            try { dim = Convert.ToInt32((string)info.GetValue("Dimensione", typeof(string))); } catch { }
            for (int i = 0; i < dim; i++)
            {
                Nodo nodo = (Nodo)info.GetValue("1", typeof(Nodo));
            }
        }*/

        public Nodo(string tabella, List<string> chiaviP, List<string[]> chiaviE, List<string[]> att, List<string> allData)
        {
            this.tabella = tabella;
            chiaviPrimarie = new List<Campo>();
            attributi = new List<Campo>();
            chiaviEsterne = new List<Campo>();
            figli = new List<Nodo>();
            //aggiunta nomi dei campi
            foreach (string item in chiaviP)
                chiaviPrimarie.Add(new Campo(item));
            foreach (string[] item in chiaviE)
                foreach(Campo campo in chiaviPrimarie)
                    if(campo.nome != item[0])
                    chiaviEsterne.Add(new Campo(item[0]));
            foreach (string[] item in att)
                if (!chiaviPrimarie.Exists(dato => dato.nome == item[0]) && !chiaviEsterne.Exists(dato => dato.nome == item[0]))
                    attributi.Add(new Campo(item[0]));
            //aggiunta valori dei campi
            for(int i = 0; i < allData.Count; i++)
            {
                if (i < chiaviPrimarie.Count)
                    chiaviPrimarie[i].valore = allData[i];
                else if (i - chiaviPrimarie.Count - attributi.Count < 0)
                    attributi[i - chiaviPrimarie.Count].valore = allData[i];
                else
                    chiaviEsterne[i - chiaviPrimarie.Count - attributi.Count].valore = allData[i];
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

        public string valore(string nome)
        {
            Campo campo = ChiaviPrimarie.Find(dato => dato.nome == nome);
            if(campo == null)
            {
                campo = attributi.Find(dato => dato.nome == nome);
                if(campo == null)
                    campo = chiaviEsterne.Find(dato => dato.nome == nome);
            }
            return campo.valore;
        }

        public bool Equals(Nodo nodo)
        {
            if (tabella != nodo.tabella)
                return false;
            if (!controllo(chiaviPrimarie, nodo.chiaviPrimarie))
                return false;
            if (!controllo(attributi, nodo.attributi))
                return false;
            if (!controllo(chiaviEsterne, nodo.chiaviEsterne))
                return false;
            return true;
        }

        bool controllo(List<Campo> campo, List<Campo> daConfrontare)
        {
            foreach (Campo item in campo)
                if (!daConfrontare.Exists(dato => dato.nome == item.nome && dato.valore == item.valore))
                    return false;
            return true;
        }

        /*public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            List<Nodo> lista = new List<Nodo>();
            Program.grafo.allNodos(lista);
            info.AddValue("Dimensione", lista.Count);
            for (int i = 0; i < lista.Count; i++)
                info.AddValue(i.ToString(), lista[i]);
        }*/

        public void aggiungiFiglio(Nodo figlio) => figli.Add(figlio);

        public string Tabella { get { return tabella; } }

        public List<Campo> ChiaviPrimarie { get { return chiaviPrimarie; } }

        public List<Campo> Attributi { get { return attributi; } }

        public List<Campo> ChiaviEsterne { get { return chiaviEsterne; } }

        public List<Nodo> Figli { get { return figli; } }
    }
}
