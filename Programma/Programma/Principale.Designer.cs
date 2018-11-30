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
            this.label1 = new System.Windows.Forms.Label();
            this.leggi = new System.Windows.Forms.Button();
            this.scrivi = new System.Windows.Forms.Button();
            this.panelLeggi = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelScrivi = new System.Windows.Forms.Panel();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelLeggi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTIONALE";
            // 
            // leggi
            // 
            this.leggi.BackColor = System.Drawing.Color.Lime;
            this.leggi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leggi.Location = new System.Drawing.Point(182, 69);
            this.leggi.Name = "leggi";
            this.leggi.Size = new System.Drawing.Size(83, 29);
            this.leggi.TabIndex = 1;
            this.leggi.Text = "Leggi";
            this.leggi.UseVisualStyleBackColor = false;
            this.leggi.Click += new System.EventHandler(this.leggi_Click);
            // 
            // scrivi
            // 
            this.scrivi.BackColor = System.Drawing.Color.Honeydew;
            this.scrivi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrivi.Location = new System.Drawing.Point(395, 69);
            this.scrivi.Name = "scrivi";
            this.scrivi.Size = new System.Drawing.Size(83, 29);
            this.scrivi.TabIndex = 2;
            this.scrivi.Text = "Scrivi";
            this.scrivi.UseVisualStyleBackColor = false;
            this.scrivi.Click += new System.EventHandler(this.scrivi_Click);
            // 
            // panelLeggi
            // 
            this.panelLeggi.Controls.Add(this.dataGridView1);
            this.panelLeggi.Location = new System.Drawing.Point(0, 159);
            this.panelLeggi.Name = "panelLeggi";
            this.panelLeggi.Size = new System.Drawing.Size(639, 293);
            this.panelLeggi.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(614, 263);
            this.dataGridView1.TabIndex = 2;
            // 
            // panelScrivi
            // 
            this.panelScrivi.Location = new System.Drawing.Point(0, 143);
            this.panelScrivi.Name = "panelScrivi";
            this.panelScrivi.Size = new System.Drawing.Size(642, 309);
            this.panelScrivi.TabIndex = 4;
            this.panelScrivi.Visible = false;
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(324, 114);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(141, 21);
            this.comboBox.TabIndex = 6;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.azioneComboBox);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "SELEZIONA TABELLA";
            // 
            // Principale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 450);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelLeggi);
            this.Controls.Add(this.scrivi);
            this.Controls.Add(this.leggi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelScrivi);
            this.Name = "Principale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelLeggi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button leggi;
        private System.Windows.Forms.Button scrivi;
        private System.Windows.Forms.Panel panelLeggi;
        private System.Windows.Forms.Panel panelScrivi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label3;
    }
}

