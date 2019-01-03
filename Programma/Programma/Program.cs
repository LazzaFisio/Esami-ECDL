using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MaterialSkin.Controls;
using System.Drawing;
using System.Threading;

namespace Programma
{
    static class Program
    {

        public static string scelta;
        public static string[] tabelle = new string[] { "città", "sede", "sessione", "esamesessione", "esami", "risultato", "skillcard", "esaminandi" };
        public static List<string[]> risQuery = new List<string[]>();
        public static Grafo grafo;
        public static ProgressBar progressBar;
        public static MySqlConnection connection;
        public static Thread thread;

        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }

        public static void query(MySqlDataReader reader)
        {
            Program.risQuery.Clear();
            while (reader.Read())
            {
                string[] dati = new string[reader.FieldCount];
                for (int i = 0; i < dati.Length; i++)
                    dati[i] = reader.GetValue(i).ToString();
                Program.risQuery.Add(dati);
            }
            reader.Close();
        }

        public static List<string> chiaviPrimarie(string tabella)
        {
            List<string> chiavi = new List<string>();
            query(new MySqlCommand("SHOW KEYS FROM " + tabella + " WHERE KEY_NAME = 'Primary'", Program.connection).ExecuteReader());
            foreach (string[] item in Program.risQuery)
                chiavi.Add(item[4]);
            return chiavi;
        }

        public static MaterialFlatButton creaBottone(Point point, string text, EventHandler action)
        {
            MaterialFlatButton button = new MaterialFlatButton();
            button.Text = text;
            button.Location = point;
            button.Click += action;
            return button;
        }

        public static Label creaLabel(Point point, string text, string name, string tag)
        {
            Label label = new Label();
            label.Text = text;
            label.Name = name;
            label.Tag = tag;
            label.Location = point;
            label.Font = new Font("Verdana", 10);
            return label;
        }

        public static Panel creaPanel(Size size, Point point, string name, string tag, Color color, bool allowScroll)
        {
            Panel panel = new Panel();
            panel.Size = size;
            panel.Location = point;
            panel.Name = name;
            panel.Tag = tag;
            panel.BackColor = color;
            panel.AutoScroll = allowScroll;
            return panel;
        }
    }
}
