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
        public static bool insert = false;

        int idPadre = 0;
        string tabella;
        string query = "";
        bool err = false;
        List<string> gerarchie = new List<string> { "città", "sede", "sessione", "esami", "esaminandi", "skillcard", "risultato" };
        List<string> primary = new List<string>();
        List<string> key = new List<string>();
        List<string[]> campi = new List<string[]>();
        List<MaterialLabel> label = new List<MaterialLabel>();
        List<MaterialSingleLineTextField> text = new List<MaterialSingleLineTextField>();

        Nodo daModificare = new Nodo();

        public Modifiche(string tabella, int id)
        {
            InitializeComponent();
            this.tabella = tabella;
            idPadre = id;
            creaOggetti();
            insert = true;
            if (tabella != "esami" && tabella != "esaminandi")
                rbEsistente.Enabled = false;
            else
                rbEsistente.Enabled = true;

            if (tabella == "esaminandi")
            {
                panel5.Show();
                lblEsterna.Text = "idCittà";
                Queryleggi("SELECT idCittà FROM città");
                for (int i = 0; i < Program.risQuery.Count; i++)
                    cmbEsterna.Items.Add(Program.risQuery[i][0]);
            }
        }

        public Modifiche(Nodo figlio, int idPadre)
        {
            InitializeComponent();
            tabella = figlio.Tabella;
            this.idPadre = idPadre;
            creaOggetti();
            daModificare = figlio;
            riempi();
            insert = false;

            panel4.Hide();
            if (tabella != "risultato")
                panel5.Show();
        }

        void btnConferma_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sei sicuro di voler confermare questi dati?", "Attenzione", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            Controllo controllo = new Controllo(panel3.Controls, tabella);
            if (result == DialogResult.Yes) 
            {
                if (insert)
                {
                    if (rbNuovo.Checked)
                    {
                        if (!controllaErr(controllo))
                        {
                            int index = trovaId(tabella);

                            query = "INSERT INTO " + tabella + "( ";
                            if (tabella != "esaminandi")
                                for (int i = 0; i < key.Count; i++)
                                    query += key[i] + ", ";
                            else
                                query += primary[0].ToString() + ", ";

                            for (int i = 0; i < label.Count; i++)
                                query += label[i].Text + ", ";

                            if (tabella == "esaminandi")
                                query += lblEsterna.Text;
                            else
                                query = query.Remove(query.Length - 2, 1);

                            query += ") VALUES ( ' " + index + " ', '";

                            if (idPadre != int.MaxValue && tabella != "esami" && tabella != "esaminandi")
                                query += idPadre + "', '";

                            for (int i = 0; i < text.Count; i++)
                            {
                                if (!isData(label[i].Text))
                                    query += text[i].Text + "', '";
                                else
                                    query += Convert.ToDateTime(text[i].Text).ToString("yyyy/MM/dd") + "', '";
                            }

                            if (tabella == "esaminandi")
                                query += cmbEsterna.Text + "'";
                            else
                                query = query.Remove(query.Length - 4, 3);
                            query += ")";

                            richiamaQuery(query);

                            if (tabella == "esami")
                                aggiungiDurata(index.ToString(), idPadre.ToString());

                            if (tabella == "esaminandi")
                                aggiungiSkill_Risultato(index);

                            this.Close();
                        }
                    }
                    else
                    {
                        if (controllo.Errore != 3 && cmbEsistente.Items.Contains(cmbEsistente))
                        {
                            if (tabella == "esami")
                                aggiungiDurata(cmbEsistente.Text, idPadre.ToString());
                            if (tabella == "esaminandi")
                                aggiungiSkill_Risultato(Convert.ToInt32(cmbEsistente.Text));
                        }
                        else
                            MessageBox.Show("Sono stati riscontrati degli errori", "Attenzione");

                        this.Close();
                    }
                }
                else
                {
                    if (controllaErr(controllo))
                    {
                        query = "UPDATE " + tabella + " SET ";

                        for (int i = 0; i < text.Count; i++)
                        {
                            if (!isData(label[i].Text))
                                query += label[i].Text + " = '" + text[i].Text + "', ";
                            else
                                query += label[i].Text + " = '" + Convert.ToDateTime(text[i].Text).ToString("yyyy/MM/dd") + "', ";
                        }

                        if (tabella != "esami" && tabella != "risultato")
                            query += lblEsterna.Text + " = '" + cmbEsterna.Text + "' ";
                        else
                            query = query.Remove(query.Length - 2, 1);

                        query += " WHERE ";

                        foreach (var item in daModificare.ChiaviPrimarie)
                            query += item.nome + " = '" + item.valore + " ' AND ";
                        query = query.Remove(query.Length - 5, 4);

                        richiamaQuery(query);

                        if (tabella == "esami")
                        {

                            if (Convert.ToInt32(cmbEsterna.Text) != idPadre)
                                aggiungiDurata(daModificare.ChiaviPrimarie[0].valore, cmbEsterna.Text);
                            else
                            {
                                result = MessageBox.Show("Vuoi modificare la durata dell'esame?", "Attenzione", MessageBoxButtons.YesNoCancel);
                                if (result == DialogResult.Yes)
                                {
                                    Queryleggi("SELECT durata FROM esamesessione WHERE idEsame = '" + daModificare.ChiaviPrimarie[0].valore + "' AND idSessione = '" + cmbEsterna.Text + "'");
                                    Dettagli dettagli = new Dettagli(cmbEsterna.Text, daModificare.ChiaviPrimarie[0].valore, Program.risQuery[0][0]);
                                    dettagli.ShowDialog();
                                    richiamaQuery("UPDATE esamesessione SET DurataEsame = '" + Dettagli.durata + "'WHERE" + daModificare.ChiaviPrimarie[0].nome + " = '" + daModificare.ChiaviPrimarie[0].valore + "' AND" + daModificare.ChiaviPrimarie[1].nome + " = '" + daModificare.ChiaviPrimarie[1].valore);
                                }
                            }
                        }

                        if (tabella == "esaminandi")
                        {
                            Queryleggi("SELECT idSkillCard FROM skillcard` WHERE DataScadenza >  CURRENT_DATE AND codice = '" + daModificare.ChiaviPrimarie[0].valore + "'");
                            Queryleggi("SELECT * FROM risultato WHERE idSkillCard = '" + Program.risQuery[0][0] + "' AND idEsami = '" + idPadre.ToString() + "'");
                            if (!(cmbEsterna2.Text == idPadre.ToString()))
                            {
                                richiamaQuery("DELETE FROM risultato WHERE idEsami  = '" + idPadre + "' AND idSkillCard = '" + Program.risQuery[0][1] + "'");
                                richiamaQuery("INSERT INTO risultato (idEsami,idSkillCard,esito,percentuale) VALUES ('" + cmbEsterna2.Text + " ','" + Program.risQuery[0][1] + " ','" + Program.risQuery[0][2] + " ','" + Program.risQuery[0][3] + "')");
                            }
                        }

                        this.Close();
                    }
                }
            }
        }

        void aggiungiDurata(string esame, string sessione)
        {
            Dettagli dettagli = new Dettagli(sessione,esame);
            dettagli.ShowDialog();

            if (!insert)
                richiamaQuery("DELETE FROM esamesessione WHERE idEsami = '" + daModificare.ChiaviPrimarie[0].valore + "' AND idSessione = '" + idPadre + "'");

            richiamaQuery("INSERT INTO esamesessione (idEsami,idSessione,DurataEsame) VALUES ('" + esame + "', '" + sessione + "', '" + Dettagli.durata + "')");
        }

        void aggiungiSkill_Risultato(int index)
        {
            Queryleggi("SELECT * FROM `skillcard` WHERE DataScadenza > CURRENT_DATE AND codice = '" + index + "'");

            if (Program.risQuery.Count == 0)
            {
                int idSkillCard = trovaId("skillcard");

                SkillCard skillCard = new SkillCard();
                skillCard.ShowDialog();

                richiamaQuery("INSERT INTO skillcard (idSkillCard,DataEmissione,DataScadenza,codice) VALUES ('" + idSkillCard + "', '" + SkillCard.dataEmissione + "', '" + SkillCard.dataScadenza + "', '" + index + "') ");

                richiamaQuery("INSERT INTO risultato (idEsami,idSkillCard,esito) VALUES ('" + idPadre + "',' " + idSkillCard + "', 'Non valutato')");
            }
            else
                richiamaQuery("INSERT INTO risultato (idEsami,idSkillCard,esito) VALUES ('" + idPadre + "',' " + Program.risQuery[0][0] + "', 'Non valutato')");
        }

        bool controllaErr(Controllo controllo)
        {
            if (!cmbEsterna.Items.Contains(cmbEsterna.Text))
            {
                return = true;
                MessageBox.Show("Attenzione la chiave esterna non è presente", "Errore");
            }
            else if (controllo.Errore != 0)
            {
                if (controllo.Errore == 1)
                {
                    DialogResult result = MessageBox.Show("Attenzione i dati presenti sono già esistenti. Vuoi mantenerli entrambi?", "Attenzione", MessageBoxButtons.YesNoCancel);
                    if (result != DialogResult.Yes)
                        return true;
                }
                else
                {
                    MessageBox.Show(controllo.InStringa);
                    return true;
                }
            }

            return false;
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
                    nuova.Name = campi[j][0];
                    nuova.BackColor = Color.Green;
                    nuova.Size = new Size(panel3.Width / 2 - 10, nuova.Height);
                    nuova.Text = campi[j][0];
                    panel3.Controls.Add(nuova);
                    label.Add(nuova);

                    MaterialSingleLineTextField testo = new MaterialSingleLineTextField();
                    testo.Location = new Point(panel3.Width / 2, panel3.Height / 5 * i + 5);
                    testo.Size = new Size(panel3.Width / 2 - 10, panel3.Height / 5 - 10);
                    testo.Name = campi[j][0] + "-txt";
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
            try { new MySqlCommand(query, Program.connection).ExecuteNonQuery(); }
            catch (Exception err) { MessageBox.Show(err.Message, "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        void Queryleggi(string query)
        {
            try { Program.query(new MySqlCommand(query, Program.connection).ExecuteReader());  }
            catch (Exception err) { MessageBox.Show(err.Message, "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        void riempi()
        {
            for (int i = 0; i < text.Count; i++)
                text[i].Text = daModificare.Attributi[i].valore;

            if (daModificare.ChiaviEsterne.Count > 0)
            {
                lblEsterna.Text = daModificare.ChiaviEsterne[0].nome;

                if (tabella != "esaminandi")
                    Queryleggi("SELECT " + daModificare.ChiaviEsterne[0].nome + " FROM " + gerarchie[gerarchie.FindIndex(dato => dato == daModificare.Tabella) - 1]);
                else
                    Queryleggi("SELECT " + daModificare.ChiaviEsterne[0].nome + " FROM città");


                for (int i = 0; i < Program.risQuery.Count; i++)
                    cmbEsterna.Items.Add(Program.risQuery[i][0]);

                cmbEsterna.Text = daModificare.ChiaviEsterne[0].valore;
            }
            if (tabella == "esami")
            {
                Queryleggi("SELECT idSessione FROM Sessione");
                lblEsterna.Text = "idSessione";

                for (int i = 0; i < Program.risQuery.Count; i++)
                    cmbEsterna.Items.Add(Program.risQuery[i][0]);

                cmbEsterna.Text = idPadre.ToString();

            }
            if (tabella == "esaminandi")
            {
                Queryleggi("SELECT idEsami FROM esami");
                lblEsterna2.Text = "idEsami";

                for (int i = 0; i < Program.risQuery.Count; i++)
                    cmbEsterna2.Items.Add(Program.risQuery[i][0]);

                lblEsterna2.Visible = true;
                cmbEsterna2.Visible = true;

                cmbEsterna2.Text = idPadre.ToString();
            }
            if(tabella == "città")
                cmbEsterna.Enabled = false;
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
            List<string> campi = new List<string>();
            foreach (var item in Program.risQuery)
                campi.Add(item[0]);
            for (int i = 1; i <= campi.Count; i++)
                if (!campi.Contains(i.ToString()))
                    num = i;

            if (num == 0)
                num = campi.Count + 1;

            return num;
        }

        bool isData(string campo)
        {
            string data = campo.Substring(0, 4);
            if (data.ToLower() == "data")
                return true;

            return false;
        }
    }
}