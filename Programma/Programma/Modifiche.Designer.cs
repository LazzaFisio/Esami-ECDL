﻿namespace Programma
{
    partial class Modifiche
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNuovoCampo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Conferma = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.lblCampoSelezionato = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Attributo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoreAssociato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 188);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(118, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Valore attributo:";
            // 
            // txtNuovoCampo
            // 
            this.txtNuovoCampo.Depth = 0;
            this.txtNuovoCampo.Hint = "";
            this.txtNuovoCampo.Location = new System.Drawing.Point(136, 188);
            this.txtNuovoCampo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNuovoCampo.Name = "txtNuovoCampo";
            this.txtNuovoCampo.PasswordChar = '\0';
            this.txtNuovoCampo.SelectedText = "";
            this.txtNuovoCampo.SelectionLength = 0;
            this.txtNuovoCampo.SelectionStart = 0;
            this.txtNuovoCampo.Size = new System.Drawing.Size(125, 23);
            this.txtNuovoCampo.TabIndex = 1;
            this.txtNuovoCampo.UseSystemPasswordChar = false;
            this.txtNuovoCampo.TextChanged += new System.EventHandler(this.txtNuovoCampo_TextChanged);
            // 
            // Conferma
            // 
            this.Conferma.AutoSize = true;
            this.Conferma.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Conferma.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Conferma.Depth = 0;
            this.Conferma.Location = new System.Drawing.Point(92, 310);
            this.Conferma.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Conferma.MouseState = MaterialSkin.MouseState.HOVER;
            this.Conferma.Name = "Conferma";
            this.Conferma.Primary = false;
            this.Conferma.Size = new System.Drawing.Size(85, 36);
            this.Conferma.TabIndex = 2;
            this.Conferma.Text = "Conferma";
            this.Conferma.UseVisualStyleBackColor = false;
            this.Conferma.Click += new System.EventHandler(this.Conferma_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 115);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(143, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Campo selezionato:";
            // 
            // lblCampoSelezionato
            // 
            this.lblCampoSelezionato.AutoSize = true;
            this.lblCampoSelezionato.Depth = 0;
            this.lblCampoSelezionato.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCampoSelezionato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCampoSelezionato.Location = new System.Drawing.Point(161, 115);
            this.lblCampoSelezionato.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCampoSelezionato.Name = "lblCampoSelezionato";
            this.lblCampoSelezionato.Size = new System.Drawing.Size(0, 19);
            this.lblCampoSelezionato.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Attributo,
            this.valoreAssociato});
            this.dataGridView1.Location = new System.Drawing.Point(285, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(294, 286);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Attributo
            // 
            this.Attributo.HeaderText = "Attributo";
            this.Attributo.Name = "Attributo";
            this.Attributo.Width = 130;
            // 
            // valoreAssociato
            // 
            this.valoreAssociato.HeaderText = "Valore associato";
            this.valoreAssociato.Name = "valoreAssociato";
            this.valoreAssociato.Width = 120;
            // 
            // Modifiche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 371);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblCampoSelezionato);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.Conferma);
            this.Controls.Add(this.txtNuovoCampo);
            this.Controls.Add(this.materialLabel1);
            this.Name = "Modifiche";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifiche";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNuovoCampo;
        private MaterialSkin.Controls.MaterialFlatButton Conferma;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel lblCampoSelezionato;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attributo;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoreAssociato;
    }
}