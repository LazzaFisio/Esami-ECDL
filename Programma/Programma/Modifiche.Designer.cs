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
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbEsistente = new System.Windows.Forms.ComboBox();
            this.Seleziona = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl3 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl1 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl2 = new MaterialSkin.Controls.MaterialLabel();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.lbl4 = new MaterialSkin.Controls.MaterialLabel();
            this.rbEsistente = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbNuovo = new MaterialSkin.Controls.MaterialRadioButton();
            this.tabMod = new System.Windows.Forms.TabPage();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialTabControl1.SuspendLayout();
            this.tabAdd.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.materialTabControl1.Size = new System.Drawing.Size(378, 263);
            this.materialTabControl1.TabIndex = 1;
            // 
            // tabAdd
            // 
            this.tabAdd.BackColor = System.Drawing.Color.White;
            this.tabAdd.Controls.Add(this.cmb1);
            this.tabAdd.Controls.Add(this.lbl4);
            this.tabAdd.Controls.Add(this.rbEsistente);
            this.tabAdd.Controls.Add(this.rbNuovo);
            this.tabAdd.Controls.Add(this.panel1);
            this.tabAdd.Controls.Add(this.panel2);
            this.tabAdd.Location = new System.Drawing.Point(4, 22);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(370, 237);
            this.tabAdd.TabIndex = 0;
            this.tabAdd.Text = "Aggiungi";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.txt1);
            this.panel1.Controls.Add(this.txt2);
            this.panel1.Controls.Add(this.txt3);
            this.panel1.Controls.Add(this.lbl3);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Controls.Add(this.lbl2);
            this.panel1.Location = new System.Drawing.Point(29, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 140);
            this.panel1.TabIndex = 10;
            // 
            // txt1
            // 
            this.txt1.Depth = 0;
            this.txt1.Hint = "";
            this.txt1.Location = new System.Drawing.Point(158, 19);
            this.txt1.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt1.Name = "txt1";
            this.txt1.PasswordChar = '\0';
            this.txt1.SelectedText = "";
            this.txt1.SelectionLength = 0;
            this.txt1.SelectionStart = 0;
            this.txt1.Size = new System.Drawing.Size(136, 23);
            this.txt1.TabIndex = 6;
            this.txt1.UseSystemPasswordChar = false;
            // 
            // txt2
            // 
            this.txt2.Depth = 0;
            this.txt2.Hint = "";
            this.txt2.Location = new System.Drawing.Point(158, 59);
            this.txt2.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt2.Name = "txt2";
            this.txt2.PasswordChar = '\0';
            this.txt2.SelectedText = "";
            this.txt2.SelectionLength = 0;
            this.txt2.SelectionStart = 0;
            this.txt2.Size = new System.Drawing.Size(136, 23);
            this.txt2.TabIndex = 7;
            this.txt2.UseSystemPasswordChar = false;
            // 
            // txt3
            // 
            this.txt3.Depth = 0;
            this.txt3.Hint = "";
            this.txt3.Location = new System.Drawing.Point(158, 99);
            this.txt3.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt3.Name = "txt3";
            this.txt3.PasswordChar = '\0';
            this.txt3.SelectedText = "";
            this.txt3.SelectionLength = 0;
            this.txt3.SelectionStart = 0;
            this.txt3.Size = new System.Drawing.Size(136, 23);
            this.txt3.TabIndex = 8;
            this.txt3.UseSystemPasswordChar = false;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Depth = 0;
            this.lbl3.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl3.Location = new System.Drawing.Point(13, 104);
            this.lbl3.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(0, 19);
            this.lbl3.TabIndex = 4;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Depth = 0;
            this.lbl1.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl1.Location = new System.Drawing.Point(13, 24);
            this.lbl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(0, 19);
            this.lbl1.TabIndex = 2;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Depth = 0;
            this.lbl2.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl2.Location = new System.Drawing.Point(13, 64);
            this.lbl2.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(0, 19);
            this.lbl2.TabIndex = 3;
            // 
            // cmb1
            // 
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Location = new System.Drawing.Point(187, 184);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(136, 21);
            this.cmb1.TabIndex = 9;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Depth = 0;
            this.lbl4.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl4.Location = new System.Drawing.Point(33, 187);
            this.lbl4.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(85, 19);
            this.lbl4.TabIndex = 5;
            this.lbl4.Text = "Aggiunto a:";
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
            // tabMod
            // 
            this.tabMod.Location = new System.Drawing.Point(4, 22);
            this.tabMod.Name = "tabMod";
            this.tabMod.Padding = new System.Windows.Forms.Padding(3);
            this.tabMod.Size = new System.Drawing.Size(370, 237);
            this.tabMod.TabIndex = 1;
            this.tabMod.Text = "Modifica";
            this.tabMod.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(145, 368);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(85, 36);
            this.materialFlatButton1.TabIndex = 2;
            this.materialFlatButton1.Text = "conferma";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // Modifiche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 408);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.TabPage tabMod;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt1;
        private MaterialSkin.Controls.MaterialLabel lbl4;
        private MaterialSkin.Controls.MaterialLabel lbl3;
        private MaterialSkin.Controls.MaterialLabel lbl2;
        private MaterialSkin.Controls.MaterialLabel lbl1;
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