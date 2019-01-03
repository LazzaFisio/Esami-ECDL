﻿using System;
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
using System.Threading;

namespace Programma
{
    public partial class Login : MaterialForm
    {
        string data;

        public Login()
        {
            InitializeComponent();
            creaElementiAggiuntivi();
        }

        private void connetti_Click(object sender, EventArgs e)
        {
            try
            {
                data = "Server=" + server.Text + ";Database=" + database.Text + ";Uid=" + user.Text + ";Psw=" + password.Text + ";";
                Program.connection = new MySqlConnection(data);
                Program.connection.Open();
                Program.thread = new Thread(new ThreadStart(delegate
                {
                    Program.grafo = new Grafo(data, Program.tabelle.ToList());
                    for (int i = Program.grafo.IndexTabella; i < Program.tabelle.Length; i++)
                        Program.grafo.caricaGrafo(i);
                }));
                Program.thread.IsBackground = true;
                Program.thread.Start();
                timer1.Start();
            }
            catch (Exception err) { MessageBox.Show(err.Message, "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning); Show(); }
        }

        void creaElementiAggiuntivi()
        {
            Label label = new Label();
            label.Location = new Point(109, 137);
            label.Text = "STO CARICANDO I DATI";
            label.Font = new Font("Vedrana", 16, FontStyle.Regular);
            label.Tag = "Carimento";
            label.Size = new Size(300, 25);
            ProgressBar progressBar = new ProgressBar();
            progressBar.Location = new Point(114, 183);
            progressBar.Size = new Size(261, 23);
            progressBar.Maximum = Program.tabelle.Length;
            progressBar.Tag = "Carimento";
            Program.progressBar = progressBar;
            label.Visible = progressBar.Visible = false;
            Controls.Add(label);
            Controls.Add(progressBar);
        }

        void oscuraMostra(bool condizione)
        {
            foreach (Control control in Controls)
            {
                if (control.Tag == null)
                    control.Visible = condizione;
                else
                    control.Visible = !condizione;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                timer1.Stop();
                Hide();
                Program.query(new MySqlCommand("SELECT COUNT(*) FROM città", Program.connection).ExecuteReader());
                new Attesa(2, Program.risQuery[0][0]).ShowDialog();
                new Principale().ShowDialog();
                oscuraMostra(true);
                Show();
            }
            catch (Exception err) { MessageBox.Show(err.Message, "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning); oscuraMostra(true); Show(); }
        }
    }
}
