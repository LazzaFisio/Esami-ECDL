using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MaterialSkin.Animations;
using MaterialSkin.Controls;

namespace Programma
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void connetti_Click(object sender, EventArgs e)
        {
            try
            {
                string data = "Server=" + server.Text + ";Database=" + database.Text + ";Uid=" + user.Text + ";Psw=" + password.Text + ";";
                Program.connection = new MySqlConnection(data);
                Program.connection.Open();
                Hide();
                new Principale().ShowDialog();
                Show();
            }
            catch { MessageBox.Show("Errore nel tentativo di creazione di una connessione", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning); Show(); }
        }
    }
}
