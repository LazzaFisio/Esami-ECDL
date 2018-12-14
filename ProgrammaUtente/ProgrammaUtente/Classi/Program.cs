using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProgrammaUtente
{
    static class Program
    {
        public static MySqlConnection connection;
        public static string database, idUtente;
        public static List<string[]> dati = new List<string[]>();

        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }

        public static bool passwordValida(string password, string idUtente)
        {
            query(new MySqlCommand("SELECT password FROM Utenti WHERE idUtenti = '" + idUtente + "'", connection).ExecuteReader());
            if (new Sicurezza().decripta(dati[0][0]) != password)
                return false;
            return true;
        }

        public static void query(MySqlDataReader reader)
        {
            Program.dati.Clear();
            while (reader.Read())
            {
                string[] dati = new string[reader.FieldCount];
                for (int i = 0; i < dati.Length; i++)
                    dati[i] = reader.GetValue(i).ToString();
                Program.dati.Add(dati);
            }
            reader.Close();
        }
    }
}
