using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;

namespace ProgrammaUtente.Accesso
{
    public partial class Inscrizione : MaterialForm
    {
        public Inscrizione()
        {
            InitializeComponent();
            Program.query(new MySqlCommand("SELECT nome FROM città", Program.connection).ExecuteReader());
            foreach(string[] item in Program.dati)
            {
                cittàUtente.Items.Add(item[0]);
                cittaInsegnante.Items.Add(item[0]);
            }
            cittàUtente.Items.Add("Nuovo");
            cittaInsegnante.Items.Add("Nuovo");
            cittàUtente.Text = cittaInsegnante.Text = cittàUtente.Items[0].ToString();
        }

        private void salva_Click(object sender, EventArgs e)
        {
            email.Text = email.Text.Trim(' ');
            if (controlloEmail())
                try
                {
                    string appoggio = "";
                    if (utente.Checked)
                        appoggio = "'UTE%'";
                    else
                        appoggio = "'INS%'";
                    Program.query(new MySqlCommand("SELECT COUNT(idUtenti) FROM utenti WHERE idUtenti like " + appoggio, Program.connection).ExecuteReader());
                    appoggio = appoggio.Remove(4, 1);
                    appoggio = appoggio.Insert(4, " " + (Convert.ToInt32(Program.dati[0][0]) + 1).ToString());
                    new MySqlCommand("INSERT INTO utenti VALUES (" + appoggio + ", '" + email.Text + "', '" + password.Text + "')", Program.connection).ExecuteNonQuery();
                    MessageBox.Show("Inscrizione completata", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch { MessageBox.Show("Controlla la connessione al database e riempi tutti i campi", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else
                MessageBox.Show("Email già registrata", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void annulla_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void utente_CheckedChanged(object sender, EventArgs e)
        {
            panelUtente.Visible = true;
            panelInsegnante.Visible = false;
        }

        private void insegnante_CheckedChanged(object sender, EventArgs e)
        {
            panelInsegnante.Visible = true;
            panelUtente.Visible = false;
        }

        private void cittàUtente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(((ComboBox)sender).Text == "Nuovo")
            {
                //da fare
            }
        }

        bool controlloEmail()
        {
            Program.query(new MySqlCommand("SELECT email FROM utenti", Program.connection).ExecuteReader());
            foreach (string[] item in Program.dati)
                if (item[0] == email.Text)
                    return false;
            return true;
        }
    }
}
