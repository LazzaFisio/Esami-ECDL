namespace ProgrammaUtente.Interfacce
{
    partial class Utente
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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabEsami = new System.Windows.Forms.TabPage();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabMod = new System.Windows.Forms.TabPage();
            this.txtPwd = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.lblNomeUtente = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.txtUtente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCognome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnConferma = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioM = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioF = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialTabControl1.SuspendLayout();
            this.tabEsami.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabMod.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabEsami);
            this.materialTabControl1.Controls.Add(this.tabMod);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(-1, 90);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(456, 308);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabEsami
            // 
            this.tabEsami.BackColor = System.Drawing.Color.White;
            this.tabEsami.Controls.Add(this.materialFlatButton2);
            this.tabEsami.Controls.Add(this.dataGridView1);
            this.tabEsami.Controls.Add(this.materialLabel1);
            this.tabEsami.Location = new System.Drawing.Point(4, 22);
            this.tabEsami.Name = "tabEsami";
            this.tabEsami.Padding = new System.Windows.Forms.Padding(3);
            this.tabEsami.Size = new System.Drawing.Size(448, 282);
            this.tabEsami.TabIndex = 0;
            this.tabEsami.Text = "Esami";
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(113, 237);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(204, 36);
            this.materialFlatButton2.TabIndex = 2;
            this.materialFlatButton2.Text = "Iscriviti a un nuovo esame";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(408, 191);
            this.dataGridView1.TabIndex = 1;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(9, 20);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(88, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "I tuoi esami";
            // 
            // tabMod
            // 
            this.tabMod.BackColor = System.Drawing.Color.White;
            this.tabMod.Controls.Add(this.panel2);
            this.tabMod.Controls.Add(this.panel1);
            this.tabMod.Location = new System.Drawing.Point(4, 22);
            this.tabMod.Name = "tabMod";
            this.tabMod.Padding = new System.Windows.Forms.Padding(3);
            this.tabMod.Size = new System.Drawing.Size(448, 282);
            this.tabMod.TabIndex = 1;
            this.tabMod.Text = "Modifica dati utente";
            // 
            // txtPwd
            // 
            this.txtPwd.Depth = 0;
            this.txtPwd.Hint = "";
            this.txtPwd.Location = new System.Drawing.Point(170, 125);
            this.txtPwd.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '\0';
            this.txtPwd.SelectedText = "";
            this.txtPwd.SelectionLength = 0;
            this.txtPwd.SelectionStart = 0;
            this.txtPwd.Size = new System.Drawing.Size(146, 23);
            this.txtPwd.TabIndex = 5;
            this.txtPwd.UseSystemPasswordChar = false;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(170, 184);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(85, 36);
            this.materialFlatButton1.TabIndex = 4;
            this.materialFlatButton1.Text = "Conferma";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(64, 125);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(79, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Password:";
            // 
            // lblNomeUtente
            // 
            this.lblNomeUtente.AutoSize = true;
            this.lblNomeUtente.Depth = 0;
            this.lblNomeUtente.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNomeUtente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNomeUtente.Location = new System.Drawing.Point(170, 81);
            this.lblNomeUtente.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNomeUtente.Name = "lblNomeUtente";
            this.lblNomeUtente.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNomeUtente.Size = new System.Drawing.Size(0, 19);
            this.lblNomeUtente.TabIndex = 1;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(64, 81);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(100, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Nome utente:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPwd);
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.materialFlatButton1);
            this.panel1.Controls.Add(this.lblNomeUtente);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 276);
            this.panel1.TabIndex = 7;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(64, 34);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(289, 19);
            this.materialLabel4.TabIndex = 6;
            this.materialLabel4.Text = "Inserisci la password per modificare i dati";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-1, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(456, 25);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioF);
            this.panel2.Controls.Add(this.radioM);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.materialLabel10);
            this.panel2.Controls.Add(this.btnConferma);
            this.panel2.Controls.Add(this.txtCognome);
            this.panel2.Controls.Add(this.txtNome);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.txtUtente);
            this.panel2.Controls.Add(this.materialLabel9);
            this.panel2.Controls.Add(this.materialLabel8);
            this.panel2.Controls.Add(this.materialLabel7);
            this.panel2.Controls.Add(this.materialLabel6);
            this.panel2.Controls.Add(this.materialLabel5);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(445, 279);
            this.panel2.TabIndex = 7;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(56, 24);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(96, 19);
            this.materialLabel5.TabIndex = 8;
            this.materialLabel5.Text = "Nome utente";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(266, 24);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(75, 19);
            this.materialLabel6.TabIndex = 9;
            this.materialLabel6.Text = "Password";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(64, 91);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(50, 19);
            this.materialLabel7.TabIndex = 10;
            this.materialLabel7.Text = "Nome";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(64, 128);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(74, 19);
            this.materialLabel8.TabIndex = 11;
            this.materialLabel8.Text = "Cognome";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(64, 168);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(51, 19);
            this.materialLabel9.TabIndex = 12;
            this.materialLabel9.Text = "Sesso";
            // 
            // txtUtente
            // 
            this.txtUtente.Depth = 0;
            this.txtUtente.Hint = "";
            this.txtUtente.Location = new System.Drawing.Point(24, 46);
            this.txtUtente.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUtente.Name = "txtUtente";
            this.txtUtente.PasswordChar = '\0';
            this.txtUtente.SelectedText = "";
            this.txtUtente.SelectionLength = 0;
            this.txtUtente.SelectionStart = 0;
            this.txtUtente.Size = new System.Drawing.Size(193, 23);
            this.txtUtente.TabIndex = 14;
            this.txtUtente.UseSystemPasswordChar = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Depth = 0;
            this.txtPassword.Hint = "";
            this.txtPassword.Location = new System.Drawing.Point(240, 46);
            this.txtPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.Size = new System.Drawing.Size(193, 23);
            this.txtPassword.TabIndex = 15;
            this.txtPassword.UseSystemPasswordChar = false;
            // 
            // txtNome
            // 
            this.txtNome.Depth = 0;
            this.txtNome.Hint = "";
            this.txtNome.Location = new System.Drawing.Point(184, 91);
            this.txtNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.Size = new System.Drawing.Size(142, 23);
            this.txtNome.TabIndex = 16;
            this.txtNome.UseSystemPasswordChar = false;
            // 
            // txtCognome
            // 
            this.txtCognome.Depth = 0;
            this.txtCognome.Hint = "";
            this.txtCognome.Location = new System.Drawing.Point(184, 128);
            this.txtCognome.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.PasswordChar = '\0';
            this.txtCognome.SelectedText = "";
            this.txtCognome.SelectionLength = 0;
            this.txtCognome.SelectionStart = 0;
            this.txtCognome.Size = new System.Drawing.Size(142, 23);
            this.txtCognome.TabIndex = 17;
            this.txtCognome.UseSystemPasswordChar = false;
            // 
            // btnConferma
            // 
            this.btnConferma.AutoSize = true;
            this.btnConferma.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConferma.Depth = 0;
            this.btnConferma.Location = new System.Drawing.Point(170, 235);
            this.btnConferma.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConferma.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Primary = false;
            this.btnConferma.Size = new System.Drawing.Size(85, 36);
            this.btnConferma.TabIndex = 20;
            this.btnConferma.Text = "Conferma";
            this.btnConferma.UseVisualStyleBackColor = true;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(64, 207);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(41, 19);
            this.materialLabel10.TabIndex = 21;
            this.materialLabel10.Text = "Città";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(184, 205);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 21);
            this.comboBox1.TabIndex = 22;
            // 
            // radioM
            // 
            this.radioM.AutoSize = true;
            this.radioM.Depth = 0;
            this.radioM.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioM.Location = new System.Drawing.Point(184, 163);
            this.radioM.Margin = new System.Windows.Forms.Padding(0);
            this.radioM.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioM.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioM.Name = "radioM";
            this.radioM.Ripple = true;
            this.radioM.Size = new System.Drawing.Size(41, 30);
            this.radioM.TabIndex = 23;
            this.radioM.TabStop = true;
            this.radioM.Text = "M";
            this.radioM.UseVisualStyleBackColor = true;
            // 
            // radioF
            // 
            this.radioF.AutoSize = true;
            this.radioF.Depth = 0;
            this.radioF.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioF.Location = new System.Drawing.Point(240, 163);
            this.radioF.Margin = new System.Windows.Forms.Padding(0);
            this.radioF.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioF.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioF.Name = "radioF";
            this.radioF.Ripple = true;
            this.radioF.Size = new System.Drawing.Size(36, 30);
            this.radioF.TabIndex = 24;
            this.radioF.TabStop = true;
            this.radioF.Text = "F";
            this.radioF.UseVisualStyleBackColor = true;
            // 
            // Utente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 402);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "Utente";
            this.Text = "Utente";
            this.materialTabControl1.ResumeLayout(false);
            this.tabEsami.ResumeLayout(false);
            this.tabEsami.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabMod.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabEsami;
        private System.Windows.Forms.TabPage tabMod;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel lblNomeUtente;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPwd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialFlatButton btnConferma;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCognome;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNome;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUtente;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialRadioButton radioF;
        private MaterialSkin.Controls.MaterialRadioButton radioM;
    }
}