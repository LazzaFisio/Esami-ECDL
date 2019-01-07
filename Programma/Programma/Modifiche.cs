﻿using System;
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

        int idPadre = 0, idCittà = 0;
        string tabella;
        string query = "";
        List<string> gerarchie = new List<string> { "città", "sede", "sessione", "esami", "esaminandi", "skillcard", "risultato" };
        List<string> primary = new List<string>();
        List<string> key = new List<string>();
        List<string[]> campi = new List<string[]>();
        List<MaterialLabel> label = new List<MaterialLabel>();
        List<MaterialSingleLineTextField> text = new List<MaterialSingleLineTextField>();

        Nodo daModificare = new Nodo();

        public Modifiche(string tabella, int id, int idCittà)
        {
            InitializeComponent();
            this.tabella = tabella;
            idPadre = id;
            this.idCittà = idCittà;
            creaOggetti();
            insert = true;
            if (tabella != "esami" && tabella != "esaminandi")
                rbEsistente.Enabled = false;
            else
                rbEsistente.Enabled = true;
        }

        public Modifiche(Nodo figlio)
        {
            InitializeComponent();
            tabella = figlio.Tabella;
            creaOggetti();
            daModificare = figlio;
            riempi(figlio.Attributi);
            insert = false;
        }

        void btnConferma_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sei sicuro di voler confermare questi dati?", "Attenzione", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (insert)
                {
                    if (rbNuovo.Checked)
                    {
                        int index = trovaId(tabella);

                        query = "INSERT INTO " + tabella + "( ";
                        for (int i = 0; i < key.Count; i++)
                            query += key[i] + ", ";
                        for (int i = 0; i < label.Count; i++)
                            query += label[i].Text + ", ";
                        query = query.Remove(query.Length - 2, 1);
                        query += ") VALUES ( ' ";
                        query += index + " ', '";
                        if (idPadre != int.MaxValue && tabella != "esami")
                            if (tabella != "esaminandi")
                                query += idPadre + "', '";
                            else
                                query += idCittà + "', '";
                        for (int i = 0; i < text.Count; i++)
                            if (tabella != "sessione")
                                query += text[i].Text + "', '";
                            else
                                query += Convert.ToDateTime(text[i].Text).ToString("yyyy/MM/dd") + "', '";
                        query = query.Remove(query.Length - 4, 3);
                        query += ")";

                        richiamaQuery(query);

                        if (tabella == "esami")
                            aggiungiDurata(index.ToString(), idPadre.ToString());

                        if (tabella == "esaminandi")
                        {
                            aggiungiSkill_Risultato(index);
                        }
                    }
                    else
                    {
                        if (tabella == "esami")
                            aggiungiDurata(cmbEsistente.Text, idPadre.ToString());
                        if (tabella == "esaminandi")
                            aggiungiSkill_Risultato(Convert.ToInt32(cmbEsistente.Text));
                    }
                }
                else
                {
                    query = "UPDATE " + tabella + " SET ";
                    for (int i = 0; i < text.Count; i++)
                        query += label[i].Text + " = '" + text[i].Text + "', ";
                    /*
                     Modifiche delle chiavi esterne   
                     */
                    query += " WHERE ";
                    foreach (var item in daModificare.ChiaviPrimarie)
                        query += item.nome + " = '" + item.valore + "', ";
                    query.Remove(query.Length - 2, 1);
                    query += ";";

                    richiamaQuery(query);
                }
            }
        }

        void aggiungiDurata(string esame, string sessione)
        {
            Dettagli dettagli = new Dettagli(sessione,esame);
            dettagli.ShowDialog();
            if (Dettagli.durata != "")
                if (tabella == "esami")
                    richiamaQuery("INSERT INTO esamesessione (idEsami,idSessione,DurataEsame) VALUES ('" + esame + "', '" + sessione + "', '" + Dettagli.durata + "')");
        }

        void aggiungiSkill_Risultato(int index)
        {
            Queryleggi("SELECT * FROM `skillcard` WHERE DataScadenza > CURRENT_DATE AND Esaminandi_codice = '" + index + "'");

            if (Program.risQuery.Count == 0)
            {
                int idSkillCard = trovaId("skillcard");

                SkillCard skillCard = new SkillCard();
                skillCard.ShowDialog();
                if (SkillCard.dataEmissione != "" && SkillCard.dataScadenza != "")
                    richiamaQuery("INSERT INTO skillcard (idSkillCard,DataEmissione,DataScadenza,Esaminandi_codice) VALUES ('" + idSkillCard + "', '" + SkillCard.dataEmissione + "', '" + SkillCard.dataScadenza + "', '" + index + "') ");

                richiamaQuery("INSERT INTO risultato (idEsami,idSkillCard,esito) VALUES ('" + idPadre + "',' " + idSkillCard + "', 'Non valutato')");
            }
            else
                richiamaQuery("INSERT INTO risultato (idEsami,idSkillCard,esito) VALUES ('" + idPadre + "',' " + Program.risQuery[0][0] + "', 'Non valutato')");
        }

        void creaOggetti()
        {
            Program.query(new MySqlCommand("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = 'esami ecdl' AND TABLE_NAME = '" + tabella + "'", Program.connection).ExecuteReader());
            campi.Clear();
            foreach (var item in Program.risQuery)
                campi.Add(item);

            Program.query(new MySqlCommand("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE WHERE TABLE_NAME = '"  + tabella + "' AND TABLE_SCHEMA = 'esami ecdl'", Program.connection).ExecuteReader());
            key.Clear();
            for (int i = 0; i < Program.risQuery.Count; i++)
                key.Add(Program.risQuery[i][0]);

            for (int i = 0, j = 0; i < campi.Count; i++,j++)
            {
                if (!key.Contains(campi[j][0]))
                {
                    MaterialLabel nuova = new MaterialLabel();
                    nuova.Location = new Point(5, panel3.Height / 5 * i + 5);
                    nuova.Name = "lbl" + i;
                    nuova.BackColor = Color.Green;
                    nuova.Size = new Size(panel3.Width / 2 - 10, nuova.Height);
                    nuova.Text = campi[j][0];
                    panel3.Controls.Add(nuova);
                    label.Add(nuova);

                    MaterialSingleLineTextField testo = new MaterialSingleLineTextField();
                    testo.Location = new Point(panel3.Width / 2, panel3.Height / 5 * i + 5);
                    testo.Size = new Size(panel3.Width / 2 - 10, panel3.Height / 5 - 10);
                    testo.Name = "txt" + i;
                    testo.BackColor = Color.Blue;

                    panel3.Controls.Add(testo);
                    text.Add(testo);
                }
            }

            if (tabella == "esami" || tabella == "esaminandi")
            {
                int index = gerarchie.FindIndex(dato => dato == tabella);
                if (tabella == "esami")
                    labelcmb.Text = "Aggiungi esame alla sessione: " + idPadre;
                if (tabella == "esaminandi")
                    labelcmb.Text = "Aggiungi esaminado all'esame: " + idPadre;

                riempiCmb(cmbEsistente, lblSeleziona, index);
            }
        }

        void rb_CheckedChanged(object sender, EventArgs e)
        {
            panel3.Hide();
            panel2.Hide();

            if (rbNuovo.Checked)
                panel3.Show();
            else
                panel2.Show();
        }

        void richiamaQuery(string query)
        {
            try { new MySqlCommand(query, Program.connection).ExecuteNonQuery(); this.Close(); }
            catch (Exception err) { MessageBox.Show(err.Message, "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        void Queryleggi(string query)
        {
            try { Program.query(new MySqlCommand(query, Program.connection).ExecuteReader()); this.Close(); }
            catch (Exception err) { MessageBox.Show(err.Message, "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        void riempi(List<Programma.Campo> valori)
        {
            for (int i = 0; i < text.Count; i++)
                text[i].Text = valori[i].valore;
        }

        void riempiCmb(ComboBox cmb, Label lbl, int index)
        {
            string id = "";
            if (gerarchie[index] != "esaminandi")
                id = "id" + gerarchie[index];
            else
                id = "codice";
            lbl.Text = id;
            Program.query(new MySqlCommand("SELECT " + id + " FROM " + gerarchie[index], Program.connection).ExecuteReader());
            campi.Clear();
            foreach (var item in Program.risQuery)
                campi.Add(item);
            for (int i = 0; i < campi.Count; i++)
                cmb.Items.Add(campi[i][0]);
        }

        int trovaId(string tabella)
        {
            int num = 0;

            primary = Program.chiaviPrimarie(tabella);

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