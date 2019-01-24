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

namespace Programma
{
    public partial class Elimina : MaterialForm
    {
        MaterialTabControl tabelle;
        MaterialTabSelector selector;
        Nodo nodo;
        Panel panel;
        List<Nodo> nodos = new List<Nodo>();

        public Elimina(Nodo nodo, Panel panel)
        {
            InitializeComponent();
            this.nodo = nodo;
            this.panel = panel;
            genera(nodo, panel, true);
        }

        void genera(Nodo nodo, Panel appoggio, bool contruttore)
        {
            tabelle = new MaterialTabControl();
            tabelle.Location = new Point(0, 275);
            tabelle.Size = new Size(800, 291);
            if (contruttore)
            {
                Panel panel = new Panel();
                panel.Size = appoggio.Size;
                panel.Location = new Point(280, 80);
                panel.BackColor = appoggio.BackColor;
                foreach (Control control in appoggio.Controls)
                    panel.Controls.Add(Program.creaLabel(control.Location, control.Text, control.Text, control.Tag.ToString()));
                Controls.Add(panel);
            }
            caricaDati(nodo);
            selector = new MaterialTabSelector();
            selector.Location = new Point(0, 246);
            selector.Size = new Size(800, 29);
            selector.BaseTabControl = tabelle;
            selector.Name = "selector";
            if (tabelle.TabPages.Count > 0)
            {
                Controls.Add(tabelle);
                Controls.Add(selector);
            }
            else
            {
                modifica.Visible = btnElimina.Visible = false;
                eliminaPanel.Visible = true;
            }
        }

        void caricaDati(Nodo nodo)
        {
            List<Nodo> app = new List<Nodo>() { nodo };
            List<Nodo> valori = new List<Nodo>();
            List<string> tabellePassate = new List<string>();
            controllo(app, valori, tabellePassate);
            while(valori.Count > 0)
            {
                foreach (Nodo item in valori)
                    if (item.Tabella != "esamesessione"){
                        DataGridView data = null;
                        for (int i = 0; i < tabelle.TabPages.Count; i++)
                        {
                            TabPage page = tabelle.TabPages[i];
                            if (page.Name == item.Tabella)
                            {
                                if (page.Controls.Count > 0)
                                    data = (DataGridView)page.Controls[0];
                                i = tabelle.TabPages.Count;
                            }
                        }
                        if (data == null)
                            creaDataGridView(ref data, item);
                        caricaValori(data, item);
                        if (!tabellePassate.Contains(item.Tabella))
                            tabellePassate.Add(item.Tabella);
                    }
                app.Clear();
                foreach (Nodo item in valori)
                {
                    app.Add(item);
                    nodos.Add(item);
                }
                valori.Clear();
                controllo(app, valori, tabellePassate);
            }
        }

        void creaDataGridView(ref DataGridView data, Nodo item)
        {
            data = new DataGridView();
            data.Name = item.Tabella;
            data.Size = new Size(tabelle.Size.Width, tabelle.Size.Height);
            data.Location = new Point(0, 0);
            data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data.AllowUserToAddRows = false;
            data.AllowUserToDeleteRows = false;
            List<string> app = infoNodo(item, true);
            foreach (string item1 in app)
                data.Columns.Add(item1, item1);
            TabPage tabPage = new TabPage(item.Tabella);
            tabPage.Name = item.Tabella;
            tabPage.Controls.Add(data);
            tabelle.TabPages.Add(tabPage);
        }

        void caricaValori(DataGridView data, Nodo appoggio)
        {
            List<string> dati = infoNodo(appoggio, false);
            data.Rows.Add(dati[0]);
            for (int i = 1; i < dati.Count; i++)
                data.Rows[data.Rows.Count - 1].Cells[i].Value = dati[i];
            data.Rows[data.Rows.Count - 1].ReadOnly = true;
        }

        void controllo(List<Nodo> nodos, List<Nodo> valori, List<string> tabelle)
        {
            foreach(Nodo item in nodos)
            {
                string cond = "REFERENCED_COLUMN_NAME = '" + item.ChiaviPrimarie[0].nome + "'";
                Program.query(new MySqlCommand("SELECT table_name, column_name FROM information_schema.KEY_COLUMN_USAGE WHERE referenced_table_name IS NOT NULL AND " + cond, Program.connection).ExecuteReader());
                List<string[]> ris = new List<string[]>();
                foreach (string[] item1 in Program.risQuery)
                    ris.Add(item1);
                if (item.Tabella != "esamesessione")
                {
                    foreach (string[] item1 in ris)
                        if (!tabelle.Contains(item1[0]))
                            aggiugiNodo(item1[0], cond, item1[1], item, valori);
                }
                else
                    aggiugiNodo("esami" ,cond, item.ChiaviPrimarie[0].nome, item, valori);
                        
            }

        }

        void aggiugiNodo(string tabella, string cond, string item1, Nodo item, List<Nodo> valori)
        {
            cond = " WHERE " + item1 + " = '" + item.ChiaviPrimarie[0].valore + "'";
            Program.query(new MySqlCommand("SELECT * FROM " + tabella + cond, Program.connection).ExecuteReader());
            List<string[]> ris1 = new List<string[]>();
            foreach (string[] item2 in Program.risQuery)
                ris1.Add(item2);
            for (int i = 0; i < ris1.Count; i++)
                valori.Add(Program.creaNodo(tabella, i, cond));
        }

        List<string> infoNodo(Nodo nodo, bool nome)
        {
            List<string> appoggio = new List<string>();
            foreach (Campo item in nodo.ChiaviPrimarie)
                appoggio.Add(info(item, nome));
            foreach (Campo item in nodo.Attributi)
                appoggio.Add(info(item, nome));
            foreach (Campo item in nodo.ChiaviEsterne)
                appoggio.Add(info(item, nome));
            return appoggio;
        }

        string info(Campo campo, bool nome)
        {
            if (nome)
                return campo.nome;
            else
                return campo.valore;
        }

        private void modifica_Click(object sender, EventArgs e)
        {
            Nodo nodo = selezionato();
            string tabPrec = "";
            for(int i = Program.tabelle.ToList().FindIndex(dato => dato == nodo.Tabella) - 1; i >= 0; i--)
                if (Principale.mostra.Contains(Program.tabelle[i]))
                {
                    tabPrec = Program.tabelle[i];
                    i = -1;
                }
            List<Nodo> appoggio = Principale.figliSucc(tabPrec, nodo.Tabella, nodo, true);
            new Modifiche(nodo, Convert.ToInt32(appoggio[0].ChiaviPrimarie[0].valore)).ShowDialog();
            aggiorna();
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            Nodo nodo = selezionato();
            try
            {
                string cond = condizione(nodo);
                new MySqlCommand("DELETE FROM " + nodo.Tabella + cond, Program.connection).ExecuteNonQuery();
                MessageBox.Show("Eliminato con successo");
                aggiorna();
            }
            catch { MessageBox.Show("Impossibile eliminare perchè ci sono dei campi collegati", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void eliminaPanel_Click(object sender, EventArgs e)
        {
            string cond = condizione(nodo);
            new MySqlCommand("DELETE FROM " + nodo.Tabella + cond, Program.connection).ExecuteNonQuery();
            Close();
        }

        Nodo selezionato()
        {
            DataGridView data = (DataGridView)tabelle.SelectedTab.Controls[0];
            List<string> chiavi = Program.chiaviPrimarie(data.Name);
            DataGridViewRow row = new DataGridViewRow();
            string cond = " WHERE ";
            if (data.SelectedRows.Count == 0)
                row = data.SelectedCells[0].OwningRow;
            else
                row = data.SelectedRows[0];
            for (int i = 0; i < chiavi.Count; i++)
                cond += chiavi[i] + " = '" + row.Cells[i].Value.ToString() + "' AND ";
            cond = cond.Remove(cond.Length - 4, 4);
            Nodo daTrovare = Program.creaNodo(data.Name, 0, cond);
            return nodos.Find(dato => dato.Equals(daTrovare));
        }

        string condizione(Nodo nodo)
        {
            string cond = " WHERE ";
            foreach (Campo item in nodo.ChiaviPrimarie)
                cond += item.nome + " = '" + item.valore + "' AND ";
            cond = cond.Remove(cond.Length - 4, 4);
            return cond;
        }

        void aggiorna()
        {
            Controls.Remove(selector);
            Controls.Remove(tabelle);
            genera(this.nodo, panel, false);
        }
    }
}
