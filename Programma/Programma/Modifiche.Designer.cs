namespace Programma
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
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.lblCampoSelezionato = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Attributo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoreAssociato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conferma = new System.Windows.Forms.Button();
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
            // conferma
            // 
            this.conferma.Location = new System.Drawing.Point(78, 292);
            this.conferma.Name = "conferma";
            this.conferma.Size = new System.Drawing.Size(104, 33);
            this.conferma.TabIndex = 6;
            this.conferma.Text = "Conferma";
            this.conferma.UseVisualStyleBackColor = true;
            this.conferma.Click += new System.EventHandler(this.Conferma_Click);
            // 
            // Modifiche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 371);
            this.Controls.Add(this.conferma);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblCampoSelezionato);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtNuovoCampo);
            this.Controls.Add(this.materialLabel1);
            this.MaximizeBox = false;
            this.Name = "Modifiche";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifiche";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNuovoCampo;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel lblCampoSelezionato;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attributo;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoreAssociato;
        private System.Windows.Forms.Button conferma;
    }
}