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
        List<DataGridView> dataGridViews = new List<DataGridView>();

        public Elimina(Nodo nodo, Panel appoggio)
        {
            InitializeComponent();
            tabelle = new MaterialTabControl();
            tabelle.Location = new Point(0, 275);
            tabelle.Size = new Size(800, 291);
            Controls.Add(tabelle);
            Panel panel = new Panel();
            panel.Size = appoggio.Size;
            panel.Location = new Point(280, 80);
            panel.BackColor = appoggio.BackColor;
            foreach (Control control in appoggio.Controls)
                panel.Controls.Add(Program.creaLabel(control.Location, control.Text, control.Text, control.Tag.ToString()));
            Controls.Add(panel);
            caricaDati(nodo);
            MaterialTabSelector selector = new MaterialTabSelector();
            selector.Location = new Point(0, 246);
            selector.Size = new Size(800, 29);
            selector.BaseTabControl = tabelle;
            Controls.Add(selector);
        }

        void caricaDati(Nodo nodo)
        {
            List<Nodo> nodos = new List<Nodo>() { nodo};
            List<Nodo> valori = new List<Nodo>();
            List<string> tabellePassate = new List<string>();
            controllo(nodos, valori, tabellePassate);
            while(valori.Count > 0)
            {
                foreach(Nodo item in valori)
                {
                    DataGridView data = dataGridViews.Find(dato => dato.Name.Split(':')[1] == item.Tabella);
                    if (data == null)
                        creaDataGridView(ref data, item);
                    caricaValori(data, item);
                    if (!tabellePassate.Contains(item.Tabella))
                        tabellePassate.Add(item.Tabella);
                }
                nodos.Clear();
                foreach (Nodo item in valori)
                    nodos.Add(item);
                valori.Clear();
                controllo(nodos, valori, tabellePassate);
            }
        }

        void creaDataGridView(ref DataGridView data, Nodo item)
        {
            data = new DataGridView();
            data.Name = "tabella:" + item.Tabella;
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
            dataGridViews.Add(data);
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
                foreach (string[] item1 in ris)
                    if(!tabelle.Contains(item1[0]))
                    {
                        cond = " WHERE " + item1[1] + " = '" + item.ChiaviPrimarie[0].valore + "'";
                        Program.query(new MySqlCommand("SELECT * FROM " + item1[0] + cond, Program.connection).ExecuteReader());
                        List<string[]> ris1 = new List<string[]>();
                        foreach (string[] item2 in Program.risQuery)
                            ris1.Add(item2);
                        for (int i = 0; i < ris1.Count; i++)
                            valori.Add(Program.creaNodo(item1[0], i, cond));
                    }
            }

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
    }
}
