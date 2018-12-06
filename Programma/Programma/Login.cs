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
                Program.database = "Server=" + server.Text + ";Database=" + database.Text + ";Uid=" + user.Text + ";Psw=" + password.Text + ";";
                Program.connection = new MySqlConnection(Program.database);
                Program.connection.Open();
                Program.database = database.Text;
                Hide();
                new Principale().ShowDialog();
                Show();
            }
            catch { MessageBox.Show("Errore nel tentativo di creazione di una connessione", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning); Show(); }
        }
    }
}
