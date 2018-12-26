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
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.lbl5 = new MaterialSkin.Controls.MaterialLabel();
            this.rbEsistente = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbNuovo = new MaterialSkin.Controls.MaterialRadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbEsistente = new System.Windows.Forms.ComboBox();
            this.Seleziona = new MaterialSkin.Controls.MaterialLabel();
            this.tabMod = new System.Windows.Forms.TabPage();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialTabControl1.SuspendLayout();
            this.tabAdd.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Enabled = false;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(388, 23);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabAdd);
            this.materialTabControl1.Controls.Add(this.tabMod);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 90);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(378, 284);
            this.materialTabControl1.TabIndex = 1;
            // 
            // tabAdd
            // 
            this.tabAdd.BackColor = System.Drawing.Color.White;
            this.tabAdd.Controls.Add(this.cmb1);
            this.tabAdd.Controls.Add(this.lbl5);
            this.tabAdd.Controls.Add(this.rbEsistente);
            this.tabAdd.Controls.Add(this.rbNuovo);
            this.tabAdd.Controls.Add(this.panel1);
            this.tabAdd.Controls.Add(this.panel2);
            this.tabAdd.Location = new System.Drawing.Point(4, 22);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(370, 258);
            this.tabAdd.TabIndex = 0;
            this.tabAdd.Text = "Aggiungi";
            // 
            // cmb1
            // 
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Location = new System.Drawing.Point(187, 224);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(136, 21);
            this.cmb1.TabIndex = 9;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Depth = 0;
            this.lbl5.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl5.Location = new System.Drawing.Point(33, 225);
            this.lbl5.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(85, 19);
            this.lbl5.TabIndex = 5;
            this.lbl5.Text = "Aggiunto a:";
            // 
            // rbEsistente
            // 
            this.rbEsistente.AutoSize = true;
            this.rbEsistente.Depth = 0;
            this.rbEsistente.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbEsistente.Location = new System.Drawing.Point(187, 8);
            this.rbEsistente.Margin = new System.Windows.Forms.Padding(0);
            this.rbEsistente.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbEsistente.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbEsistente.Name = "rbEsistente";
            this.rbEsistente.Ripple = true;
            this.rbEsistente.Size = new System.Drawing.Size(144, 30);
            this.rbEsistente.TabIndex = 1;
            this.rbEsistente.Text = "Aggiungi esistente";
            this.rbEsistente.UseVisualStyleBackColor = true;
            this.rbEsistente.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbNuovo
            // 
            this.rbNuovo.AutoSize = true;
            this.rbNuovo.Checked = true;
            this.rbNuovo.Depth = 0;
            this.rbNuovo.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbNuovo.Location = new System.Drawing.Point(37, 8);
            this.rbNuovo.Margin = new System.Windows.Forms.Padding(0);
            this.rbNuovo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbNuovo.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbNuovo.Name = "rbNuovo";
            this.rbNuovo.Ripple = true;
            this.rbNuovo.Size = new System.Drawing.Size(125, 30);
            this.rbNuovo.TabIndex = 0;
            this.rbNuovo.TabStop = true;
            this.rbNuovo.Text = "Aggiungi nuovo";
            this.rbNuovo.UseVisualStyleBackColor = true;
            this.rbNuovo.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(29, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 180);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbEsistente);
            this.panel2.Controls.Add(this.Seleziona);
            this.panel2.Location = new System.Drawing.Point(29, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 140);
            this.panel2.TabIndex = 11;
            // 
            // cmbEsistente
            // 
            this.cmbEsistente.FormattingEnabled = true;
            this.cmbEsistente.Location = new System.Drawing.Point(161, 57);
            this.cmbEsistente.Name = "cmbEsistente";
            this.cmbEsistente.Size = new System.Drawing.Size(130, 21);
            this.cmbEsistente.TabIndex = 1;
            // 
            // Seleziona
            // 
            this.Seleziona.AutoSize = true;
            this.Seleziona.Depth = 0;
            this.Seleziona.Font = new System.Drawing.Font("Roboto", 11F);
            this.Seleziona.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Seleziona.Location = new System.Drawing.Point(3, 59);
            this.Seleziona.MouseState = MaterialSkin.MouseState.HOVER;
            this.Seleziona.Name = "Seleziona";
            this.Seleziona.Size = new System.Drawing.Size(144, 19);
            this.Seleziona.TabIndex = 0;
            this.Seleziona.Text = "Seleziona esistente:";
            // 
            // tabMod
            // 
            this.tabMod.Location = new System.Drawing.Point(4, 22);
            this.tabMod.Name = "tabMod";
            this.tabMod.Padding = new System.Windows.Forms.Padding(3);
            this.tabMod.Size = new System.Drawing.Size(370, 258);
            this.tabMod.TabIndex = 1;
            this.tabMod.Text = "Modifica";
            this.tabMod.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(145, 383);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(85, 36);
            this.materialFlatButton1.TabIndex = 2;
            this.materialFlatButton1.Text = "conferma";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // Modifiche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(387, 427);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.MaximizeBox = false;
            this.Name = "Modifiche";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifiche";
            this.materialTabControl1.ResumeLayout(false);
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.TabPage tabMod;
        private MaterialSkin.Controls.MaterialLabel lbl5;
        private MaterialSkin.Controls.MaterialRadioButton rbEsistente;
        private MaterialSkin.Controls.MaterialRadioButton rbNuovo;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbEsistente;
        private MaterialSkin.Controls.MaterialLabel Seleziona;
        private System.Windows.Forms.Panel panel1;
    }
}