using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MaterialSkin.Controls;
using System.Drawing;

namespace Programma
{
    static class Program
    {
        public static MySqlConnection connection;
        public static string database;
        public static List<string[]> risQuery = new List<string[]>();

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

        public static MaterialFlatButton creaBottone(Point point, string text, EventHandler action)
        {
            MaterialFlatButton button = new MaterialFlatButton();
            button.Text = text;
            button.Location = point;
            button.Click += action;
            return button;
        }

        public static Label creaLabel(Point point, string text)
        {
            Label label = new Label();
            label.Text = text;
            label.Location = point;
            label.Font = new Font("Verdana", 10);
            return label;
        }

        public static Panel creaPanel(Size size, Point point, string name, Color color, bool allowScroll)
        {
            Panel panel = new Panel();
            panel.Size = size;
            panel.Location = point;
            panel.Name = name;
            panel.BackColor = color;
            panel.AutoScroll = allowScroll;
            return panel;
        }
    }
}
