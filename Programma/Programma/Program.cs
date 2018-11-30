using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Programma
{
    static class Program
    {
        public static MySqlConnection connection;

        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try { connection = new MySqlConnection("Server=127.0.0.1;Database=esami ecdl;Uid=root;Psw=;"); }
            catch { Application.Run(new Login()); }
            Application.Run(new Principale());
        }
    }
}
