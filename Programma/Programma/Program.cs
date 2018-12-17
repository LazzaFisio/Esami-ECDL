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

        public static MaterialFlatButton creaBottone(Point point, string text, EventHandler action)
        {
            MaterialFlatButton button = new MaterialFlatButton();
            button.Text = text;
            button.Location = point;
            button.Click += action;
            return button;
        }

        public static MaterialLabel creaLabel(Point point, string text)
        {
            MaterialLabel label = new MaterialLabel();
            label.Text = text;
            label.Location = point;
            label.BackColor = Color.White;
            return label;
        }

        public static Panel creaPanel(Size size, Point point, string name, bool test)
        {
            Panel panel = new Panel();
            panel.Size = size;
            panel.Location = point;
            panel.Name = name;
            if (test)
                panel.BackColor = Color.LightBlue;
            else
                panel.BackColor = Color.White;
            return panel;
        }
    }
}
