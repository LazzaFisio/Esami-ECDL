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

namespace Programma
{
    public partial class Modifiche : MaterialForm
    {
        bool insert = false;
        string tabella;
        string query = "";
        List<string> gerarchie = new List<string>{ "città", "sedi", "sessioni", "esami" };
        List<string> primary = new List<string>();
        List<MaterialLabel> label = new List<MaterialLabel>();
        List<MaterialSingleLineTextField> text = new List<MaterialSingleLineTextField>();

        public Modifiche(string tabella)
        {
            InitializeComponent();
            this.tabella = tabella;
            panel1.Show();
            creaOggetti();
            insert = true;
        }

        public Modifiche(string tabella, List<string> valori)
        {
            InitializeComponent();
            this.tabella = tabella;
            panel1.Show();
            creaOggetti();
            Riempi(valori);
            insert = false;
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();

            if (rbNuovo.Checked)
                panel1.Show();
            else
                panel2.Show();
        }

        private void creaOggetti()
        {
            Program.query(new MySqlCommand("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = 'esami ecdl' AND TABLE_NAME = '" + tabella + "'", Program.connection).ExecuteReader());
            List<string[]> campi = new List<string[]>();
            foreach (var item in Program.risQuery)
                campi.Add(item);

            primary = Program.chiaviPrimarie(tabella);

            for (int i = 0, j = 0; i < campi.Count - primary.Count; i++,j++)
            {
                MaterialLabel nuova = new MaterialLabel();
                nuova.Location = new Point(5, panel1.Height / 5 * i + 5);
                nuova.Name = "lbl" + i;
                nuova.BackColor = Color.Green;
                nuova.Size = new Size(panel1.Width / 2 - 10, nuova.Height);
                while(primary.Contains(campi[j][0]))
                    j++;
                nuova.Text = campi[j][0];
                panel1.Controls.Add(nuova);
                label.Add(nuova);

                MaterialSingleLineTextField testo = new MaterialSingleLineTextField();
                testo.Location = new Point(panel1.Width / 2, panel1.Height / 5 * i + 5);
                testo.Size = new Size(panel1.Width / 2 - 10, panel1.Height / 5 - 10); 
                testo.Name = "txt" + i;
                testo.BackColor = Color.Blue;
               
                panel1.Controls.Add(testo);
                text.Add(testo);
            }

            if (tabella == "città")
                cmb1.Enabled = false;
            else
            {
                int index = gerarchie.FindIndex(dato => dato == tabella);
                index--;

                Program.query(new MySqlCommand("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = '" + gerarchie[index] + "'", Program.connection).ExecuteReader());
                campi = Program.risQuery;

                for (int i = 0; i < campi.Count; i++)
                    cmb1.Items.Add(campi[i][1]);
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Attenzione","Vuoi aggiungere questo campo",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (insert)
                {
                    int index = TrovaId(tabella);
                    query = "INSERT INTO " + tabella + "( ";
                    for (int i = 0; i < primary.Count; i++)
                        query += primary[i] + ", ";
                    for (int i = 0; i < label.Count; i++)
                        query += label[i].Text + ", ";
                    query = query.Remove(query.Length - 2, 1);
                    query += ") VALUES ( ' ";
                    query += index + " ', '";
                    for (int i = 0; i < text.Count; i++)
                        query += text[i].Text + "', '";
                    query = query.Remove(query.Length - 4, 3);
                    query += ")";
                }
                else
                {
                    query = "UPDATE " + tabella + " SET ";
                    for (int i = 0; i < text.Count; i++)
                        query += label[i].Text + " = '" + text[i].Text + "', ";
                    query = query.Remove(query.Length - 2, 1);
                    query += " WHERE ";
                    for (int i = 0; i < primary.Count; i++)
                        query += primary[i] + " = '";
                    query = query.Remove(query.Length - 2, 1);
                    query += ";";
                }

                try { new MySqlCommand(query, Program.connection).ExecuteNonQuery(); this.Close(); }
                catch (Exception err) { MessageBox.Show(err.Message, "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
        }

        private void Riempi(List<string> valori)
        {
            for (int i = 0; i < text.Count; i++)
                text[i].Text = valori[i];
        }

        private int TrovaId(string tabella)
        {
            int num = 0;

            Program.query(new MySqlCommand("SELECT " + primary[0] + " FROM " + tabella, Program.connection).ExecuteReader());
            List<string[]> campi = new List<string[]>();
            foreach (var item in Program.risQuery)
                campi.Add(item);
            for (int i = 1; i <= campi.Count; i++)
                if (i != Convert.ToInt16(campi[i - 1][0]))
                    num = i;

            if (num == 0)
                num = campi.Count + 1;

            return num;
        }
    }
}