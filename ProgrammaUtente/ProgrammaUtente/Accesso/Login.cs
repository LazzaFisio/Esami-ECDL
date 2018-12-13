using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;

namespace ProgrammaUtente
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
            connetti_Click(null, null);
        }

        private void accedi_Click(object sender, EventArgs e)
        {
            Program.query(new MySqlCommand("SELECT * FROM Utenti WHERE email = '" + email.Text + "'", Program.connection).ExecuteReader());
            try
            {
                if (Program.passwordValida(password.Text, Program.dati[0][0]))
                {
                    Hide();
                    if (Program.dati[0][0].Contains("UTE"))
                        new Interfacce.Utente().ShowDialog();
                    else
                        new Interfacce.Insegnante().ShowDialog();
                    Show();
                }
            }
            catch { MessageBox.Show("Credenziali errate", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void inscriviti_Click(object sender, EventArgs e)
        {
            Hide();
            new Accesso.Inscrizione().ShowDialog();
            Show();
        }

        private void connetti_Click(object sender, EventArgs e)
        {
            try
            {
                infoConnessione.Text = "Connetto...";
                infoConnessione.ForeColor = Color.Black;
                Program.connection = new MySqlConnection("Server=" + server.Text + ";Database=" + database.Text + ";Uid=" + username.Text + ";Psw=" + passwordDatabase.Text + ";");
                Program.connection.Open();
                Program.database = database.Text;
                infoConnessione.Text = "Connessione stabilita";
                infoConnessione.ForeColor = Color.Green;
            }
            catch
            {
                infoConnessione.Text = "Errore di connessione";
                infoConnessione.ForeColor = Color.Red;
            }
        }
    }
}
