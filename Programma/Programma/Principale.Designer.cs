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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.grigliaValori = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.materialTabControl1.SuspendLayout();
            this.Defaut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grigliaValori)).BeginInit();
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
            this.Defaut.Controls.Add(this.button3);
            this.Defaut.Controls.Add(this.button2);
            this.Defaut.Controls.Add(this.button1);
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
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(631, 332);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Fai query";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // grigliaValori
            // 
            this.grigliaValori.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grigliaValori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grigliaValori.Location = new System.Drawing.Point(9, 69);
            this.grigliaValori.Name = "grigliaValori";
            this.grigliaValori.Size = new System.Drawing.Size(614, 218);
            this.grigliaValori.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "Aggiungi";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(233, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 30);
            this.button2.TabIndex = 12;
            this.button2.Text = "Modifica";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(415, 293);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 30);
            this.button3.TabIndex = 13;
            this.button3.Text = "Elimina";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Principale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(638, 445);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "Principale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionale";
            this.materialTabControl1.ResumeLayout(false);
            this.Defaut.ResumeLayout(false);
            this.Defaut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grigliaValori)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage Defaut;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grigliaValori;
    }
}

