namespace ProgrammaUtente.Accesso
{
    partial class Inscrizione
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
            this.utente = new System.Windows.Forms.RadioButton();
            this.insegnante = new System.Windows.Forms.RadioButton();
            this.salva = new System.Windows.Forms.Button();
            this.annulla = new System.Windows.Forms.Button();
            this.panelInsegnante = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.nomeSede = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.cittaInsegnante = new System.Windows.Forms.ComboBox();
            this.cittàUtente = new System.Windows.Forms.ComboBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.maschio = new System.Windows.Forms.RadioButton();
            this.femmina = new System.Windows.Forms.RadioButton();
            this.nome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cognome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.professione = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.email = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panelInsegnante.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(225, 92);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(99, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "INSCRIZIONE";
            // 
            // utente
            // 
            this.utente.AutoSize = true;
            this.utente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.utente.Checked = true;
            this.utente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utente.Location = new System.Drawing.Point(110, 132);
            this.utente.Name = "utente";
            this.utente.Size = new System.Drawing.Size(65, 20);
            this.utente.TabIndex = 1;
            this.utente.TabStop = true;
            this.utente.Text = "Utente";
            this.utente.UseVisualStyleBackColor = false;
            // 
            // insegnante
            // 
            this.insegnante.AutoSize = true;
            this.insegnante.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.insegnante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insegnante.Location = new System.Drawing.Point(357, 132);
            this.insegnante.Name = "insegnante";
            this.insegnante.Size = new System.Drawing.Size(92, 20);
            this.insegnante.TabIndex = 2;
            this.insegnante.Text = "Insegnante";
            this.insegnante.UseVisualStyleBackColor = false;
            // 
            // salva
            // 
            this.salva.Location = new System.Drawing.Point(138, 403);
            this.salva.Name = "salva";
            this.salva.Size = new System.Drawing.Size(105, 29);
            this.salva.TabIndex = 3;
            this.salva.Text = "SALVA";
            this.salva.UseVisualStyleBackColor = true;
            this.salva.Click += new System.EventHandler(this.salva_Click);
            // 
            // annulla
            // 
            this.annulla.Location = new System.Drawing.Point(304, 403);
            this.annulla.Name = "annulla";
            this.annulla.Size = new System.Drawing.Size(105, 29);
            this.annulla.TabIndex = 4;
            this.annulla.Text = "ANNULLA";
            this.annulla.UseVisualStyleBackColor = true;
            this.annulla.Click += new System.EventHandler(this.annulla_Click);
            // 
            // panelInsegnante
            // 
            this.panelInsegnante.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelInsegnante.Controls.Add(this.cittaInsegnante);
            this.panelInsegnante.Controls.Add(this.materialLabel4);
            this.panelInsegnante.Controls.Add(this.nomeSede);
            this.panelInsegnante.Controls.Add(this.materialLabel3);
            this.panelInsegnante.Controls.Add(this.materialLabel2);
            this.panelInsegnante.Location = new System.Drawing.Point(112, 215);
            this.panelInsegnante.Name = "panelInsegnante";
            this.panelInsegnante.Size = new System.Drawing.Size(339, 163);
            this.panelInsegnante.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.professione);
            this.panel2.Controls.Add(this.cognome);
            this.panel2.Controls.Add(this.nome);
            this.panel2.Controls.Add(this.femmina);
            this.panel2.Controls.Add(this.maschio);
            this.panel2.Controls.Add(this.materialLabel9);
            this.panel2.Controls.Add(this.materialLabel8);
            this.panel2.Controls.Add(this.materialLabel7);
            this.panel2.Controls.Add(this.materialLabel6);
            this.panel2.Controls.Add(this.cittàUtente);
            this.panel2.Controls.Add(this.materialLabel5);
            this.panel2.Location = new System.Drawing.Point(84, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 166);
            this.panel2.TabIndex = 6;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(115, 16);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(42, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Sede";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(35, 58);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(54, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Nome:";
            // 
            // nomeSede
            // 
            this.nomeSede.Depth = 0;
            this.nomeSede.Hint = "";
            this.nomeSede.Location = new System.Drawing.Point(130, 54);
            this.nomeSede.MouseState = MaterialSkin.MouseState.HOVER;
            this.nomeSede.Name = "nomeSede";
            this.nomeSede.PasswordChar = '\0';
            this.nomeSede.SelectedText = "";
            this.nomeSede.SelectionLength = 0;
            this.nomeSede.SelectionStart = 0;
            this.nomeSede.Size = new System.Drawing.Size(167, 23);
            this.nomeSede.TabIndex = 3;
            this.nomeSede.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(77, 107);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(45, 19);
            this.materialLabel4.TabIndex = 4;
            this.materialLabel4.Text = "Città:";
            // 
            // cittaInsegnante
            // 
            this.cittaInsegnante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cittaInsegnante.FormattingEnabled = true;
            this.cittaInsegnante.Location = new System.Drawing.Point(152, 104);
            this.cittaInsegnante.Name = "cittaInsegnante";
            this.cittaInsegnante.Size = new System.Drawing.Size(121, 21);
            this.cittaInsegnante.TabIndex = 5;
            // 
            // cittàUtente
            // 
            this.cittàUtente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cittàUtente.FormattingEnabled = true;
            this.cittàUtente.Location = new System.Drawing.Point(169, 136);
            this.cittàUtente.Name = "cittàUtente";
            this.cittàUtente.Size = new System.Drawing.Size(121, 21);
            this.cittàUtente.TabIndex = 7;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(94, 139);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(45, 19);
            this.materialLabel5.TabIndex = 6;
            this.materialLabel5.Text = "Città:";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(85, 16);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(54, 19);
            this.materialLabel6.TabIndex = 8;
            this.materialLabel6.Text = "Nome:";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(61, 43);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(78, 19);
            this.materialLabel7.TabIndex = 9;
            this.materialLabel7.Text = "Cognome:";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(84, 77);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(55, 19);
            this.materialLabel8.TabIndex = 10;
            this.materialLabel8.Text = "Sesso:";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(45, 106);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(94, 19);
            this.materialLabel9.TabIndex = 11;
            this.materialLabel9.Text = "Professione:";
            // 
            // maschio
            // 
            this.maschio.AutoSize = true;
            this.maschio.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.maschio.Checked = true;
            this.maschio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maschio.Location = new System.Drawing.Point(180, 76);
            this.maschio.Name = "maschio";
            this.maschio.Size = new System.Drawing.Size(37, 20);
            this.maschio.TabIndex = 7;
            this.maschio.TabStop = true;
            this.maschio.Text = "M";
            this.maschio.UseVisualStyleBackColor = false;
            // 
            // femmina
            // 
            this.femmina.AutoSize = true;
            this.femmina.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.femmina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femmina.Location = new System.Drawing.Point(233, 76);
            this.femmina.Name = "femmina";
            this.femmina.Size = new System.Drawing.Size(34, 20);
            this.femmina.TabIndex = 7;
            this.femmina.Text = "F";
            this.femmina.UseVisualStyleBackColor = false;
            // 
            // nome
            // 
            this.nome.BackColor = System.Drawing.SystemColors.Control;
            this.nome.Depth = 0;
            this.nome.Hint = "";
            this.nome.Location = new System.Drawing.Point(158, 12);
            this.nome.MouseState = MaterialSkin.MouseState.HOVER;
            this.nome.Name = "nome";
            this.nome.PasswordChar = '\0';
            this.nome.SelectedText = "";
            this.nome.SelectionLength = 0;
            this.nome.SelectionStart = 0;
            this.nome.Size = new System.Drawing.Size(182, 23);
            this.nome.TabIndex = 12;
            this.nome.UseSystemPasswordChar = false;
            // 
            // cognome
            // 
            this.cognome.BackColor = System.Drawing.SystemColors.Control;
            this.cognome.Depth = 0;
            this.cognome.Hint = "";
            this.cognome.Location = new System.Drawing.Point(158, 41);
            this.cognome.MouseState = MaterialSkin.MouseState.HOVER;
            this.cognome.Name = "cognome";
            this.cognome.PasswordChar = '\0';
            this.cognome.SelectedText = "";
            this.cognome.SelectionLength = 0;
            this.cognome.SelectionStart = 0;
            this.cognome.Size = new System.Drawing.Size(182, 23);
            this.cognome.TabIndex = 13;
            this.cognome.UseSystemPasswordChar = false;
            // 
            // professione
            // 
            this.professione.BackColor = System.Drawing.SystemColors.Control;
            this.professione.Depth = 0;
            this.professione.Hint = "";
            this.professione.Location = new System.Drawing.Point(158, 102);
            this.professione.MouseState = MaterialSkin.MouseState.HOVER;
            this.professione.Name = "professione";
            this.professione.PasswordChar = '\0';
            this.professione.SelectedText = "";
            this.professione.SelectionLength = 0;
            this.professione.SelectionStart = 0;
            this.professione.Size = new System.Drawing.Size(182, 23);
            this.professione.TabIndex = 14;
            this.professione.UseSystemPasswordChar = false;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(12, 181);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(51, 19);
            this.materialLabel10.TabIndex = 15;
            this.materialLabel10.Text = "Email:";
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.Control;
            this.password.Depth = 0;
            this.password.Hint = "";
            this.password.Location = new System.Drawing.Point(370, 177);
            this.password.MouseState = MaterialSkin.MouseState.HOVER;
            this.password.Name = "password";
            this.password.PasswordChar = '\0';
            this.password.SelectedText = "";
            this.password.SelectionLength = 0;
            this.password.SelectionStart = 0;
            this.password.Size = new System.Drawing.Size(182, 23);
            this.password.TabIndex = 18;
            this.password.UseSystemPasswordChar = false;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(285, 181);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(79, 19);
            this.materialLabel11.TabIndex = 17;
            this.materialLabel11.Text = "Password:";
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.SystemColors.Control;
            this.email.Depth = 0;
            this.email.Hint = "";
            this.email.Location = new System.Drawing.Point(72, 177);
            this.email.MouseState = MaterialSkin.MouseState.HOVER;
            this.email.Name = "email";
            this.email.PasswordChar = '\0';
            this.email.SelectedText = "";
            this.email.SelectionLength = 0;
            this.email.SelectionStart = 0;
            this.email.Size = new System.Drawing.Size(182, 23);
            this.email.TabIndex = 19;
            this.email.UseSystemPasswordChar = false;
            // 
            // Inscrizione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 451);
            this.Controls.Add(this.email);
            this.Controls.Add(this.password);
            this.Controls.Add(this.materialLabel11);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.panelInsegnante);
            this.Controls.Add(this.annulla);
            this.Controls.Add(this.salva);
            this.Controls.Add(this.insegnante);
            this.Controls.Add(this.utente);
            this.Controls.Add(this.materialLabel1);
            this.Name = "Inscrizione";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscrizione";
            this.panelInsegnante.ResumeLayout(false);
            this.panelInsegnante.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.RadioButton utente;
        private System.Windows.Forms.RadioButton insegnante;
        private System.Windows.Forms.Button salva;
        private System.Windows.Forms.Button annulla;
        private System.Windows.Forms.Panel panelInsegnante;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cittaInsegnante;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField nomeSede;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField professione;
        private MaterialSkin.Controls.MaterialSingleLineTextField cognome;
        private MaterialSkin.Controls.MaterialSingleLineTextField nome;
        private System.Windows.Forms.RadioButton femmina;
        private System.Windows.Forms.RadioButton maschio;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.ComboBox cittàUtente;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialSingleLineTextField password;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialSingleLineTextField email;
    }
}