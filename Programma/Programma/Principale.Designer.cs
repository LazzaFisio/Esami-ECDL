namespace Programma
{
    partial class Principale
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.Defaut = new System.Windows.Forms.TabPage();
            this.delete = new System.Windows.Forms.Button();
            this.modica = new System.Windows.Forms.Button();
            this.aggiungi = new System.Windows.Forms.Button();
            this.grigliaValori = new System.Windows.Forms.DataGridView();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.textQuery = new System.Windows.Forms.RichTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.grigliaRisultati = new System.Windows.Forms.DataGridView();
            this.esegui = new System.Windows.Forms.Button();
            this.materialTabControl1.SuspendLayout();
            this.Defaut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grigliaValori)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grigliaRisultati)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(308, 24);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(141, 21);
            this.comboBox.TabIndex = 6;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.azioneComboBox);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.Defaut);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(-1, 93);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(639, 358);
            this.materialTabControl1.TabIndex = 7;
            // 
            // Defaut
            // 
            this.Defaut.Controls.Add(this.delete);
            this.Defaut.Controls.Add(this.modica);
            this.Defaut.Controls.Add(this.aggiungi);
            this.Defaut.Controls.Add(this.grigliaValori);
            this.Defaut.Controls.Add(this.materialLabel1);
            this.Defaut.Controls.Add(this.comboBox);
            this.Defaut.Location = new System.Drawing.Point(4, 22);
            this.Defaut.Name = "Defaut";
            this.Defaut.Size = new System.Drawing.Size(631, 332);
            this.Defaut.TabIndex = 0;
            this.Defaut.Text = "Default";
            this.Defaut.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(415, 293);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(118, 30);
            this.delete.TabIndex = 13;
            this.delete.Text = "Elimina";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // modica
            // 
            this.modica.Location = new System.Drawing.Point(233, 293);
            this.modica.Name = "modica";
            this.modica.Size = new System.Drawing.Size(118, 30);
            this.modica.TabIndex = 12;
            this.modica.Text = "Modifica";
            this.modica.UseVisualStyleBackColor = true;
            this.modica.Click += new System.EventHandler(this.modica_Click);
            // 
            // aggiungi
            // 
            this.aggiungi.Location = new System.Drawing.Point(48, 293);
            this.aggiungi.Name = "aggiungi";
            this.aggiungi.Size = new System.Drawing.Size(118, 30);
            this.aggiungi.TabIndex = 11;
            this.aggiungi.Text = "Aggiungi";
            this.aggiungi.UseVisualStyleBackColor = true;
            this.aggiungi.Click += new System.EventHandler(this.aggiungi_Click);
            // 
            // grigliaValori
            // 
            this.grigliaValori.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grigliaValori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grigliaValori.Location = new System.Drawing.Point(9, 69);
            this.grigliaValori.Name = "grigliaValori";
            this.grigliaValori.Size = new System.Drawing.Size(614, 218);
            this.grigliaValori.TabIndex = 10;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(122, 25);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(155, 19);
            this.materialLabel1.TabIndex = 9;
            this.materialLabel1.Text = "SELEZIONA TABELLA";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.esegui);
            this.tabPage3.Controls.Add(this.grigliaRisultati);
            this.tabPage3.Controls.Add(this.materialLabel3);
            this.tabPage3.Controls.Add(this.textQuery);
            this.tabPage3.Controls.Add(this.materialLabel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(631, 332);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Fai query";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(231, 80);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(146, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Risultato della query";
            // 
            // textQuery
            // 
            this.textQuery.Location = new System.Drawing.Point(152, 21);
            this.textQuery.Name = "textQuery";
            this.textQuery.Size = new System.Drawing.Size(395, 47);
            this.textQuery.TabIndex = 1;
            this.textQuery.Text = "";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(14, 37);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(132, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Scrivi qui la query:";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-1, 61);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(639, 26);
            this.materialTabSelector1.TabIndex = 8;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // grigliaRisultati
            // 
            this.grigliaRisultati.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grigliaRisultati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grigliaRisultati.Location = new System.Drawing.Point(9, 111);
            this.grigliaRisultati.Name = "grigliaRisultati";
            this.grigliaRisultati.Size = new System.Drawing.Size(614, 207);
            this.grigliaRisultati.TabIndex = 3;
            // 
            // esegui
            // 
            this.esegui.Location = new System.Drawing.Point(553, 33);
            this.esegui.Name = "esegui";
            this.esegui.Size = new System.Drawing.Size(75, 23);
            this.esegui.TabIndex = 4;
            this.esegui.Text = "Esegui";
            this.esegui.UseVisualStyleBackColor = true;
            this.esegui.Click += new System.EventHandler(this.esegui_Click);
            // 
            // Principale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(638, 445);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.MaximizeBox = false;
            this.Name = "Principale";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionale";
            this.materialTabControl1.ResumeLayout(false);
            this.Defaut.ResumeLayout(false);
            this.Defaut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grigliaValori)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grigliaRisultati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage Defaut;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button modica;
        private System.Windows.Forms.Button aggiungi;
        private System.Windows.Forms.DataGridView grigliaValori;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.RichTextBox textQuery;
        private System.Windows.Forms.DataGridView grigliaRisultati;
        private System.Windows.Forms.Button esegui;
    }
}

