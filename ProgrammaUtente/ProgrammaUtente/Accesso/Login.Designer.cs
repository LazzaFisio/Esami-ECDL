namespace ProgrammaUtente
{
    partial class Login
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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.inscriviti = new System.Windows.Forms.Button();
            this.accedi = new System.Windows.Forms.Button();
            this.password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.email = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.passwordDatabase = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.username = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.database = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.server = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.connetti = new System.Windows.Forms.Button();
            this.infoConnessione = new System.Windows.Forms.Label();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 121);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(600, 301);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabPage1.Controls.Add(this.inscriviti);
            this.tabPage1.Controls.Add(this.accedi);
            this.tabPage1.Controls.Add(this.password);
            this.tabPage1.Controls.Add(this.email);
            this.tabPage1.Controls.Add(this.materialLabel3);
            this.tabPage1.Controls.Add(this.materialLabel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(592, 275);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DATI";
            // 
            // inscriviti
            // 
            this.inscriviti.Location = new System.Drawing.Point(239, 195);
            this.inscriviti.Name = "inscriviti";
            this.inscriviti.Size = new System.Drawing.Size(121, 37);
            this.inscriviti.TabIndex = 8;
            this.inscriviti.Text = "INSCRIVITI";
            this.inscriviti.UseVisualStyleBackColor = true;
            this.inscriviti.Click += new System.EventHandler(this.inscriviti_Click);
            // 
            // accedi
            // 
            this.accedi.Location = new System.Drawing.Point(239, 143);
            this.accedi.Name = "accedi";
            this.accedi.Size = new System.Drawing.Size(121, 37);
            this.accedi.TabIndex = 7;
            this.accedi.Text = "ACCEDI";
            this.accedi.UseVisualStyleBackColor = true;
            this.accedi.Click += new System.EventHandler(this.accedi_Click);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.Control;
            this.password.Depth = 0;
            this.password.Hint = "";
            this.password.Location = new System.Drawing.Point(255, 87);
            this.password.MouseState = MaterialSkin.MouseState.HOVER;
            this.password.Name = "password";
            this.password.PasswordChar = '\0';
            this.password.SelectedText = "";
            this.password.SelectionLength = 0;
            this.password.SelectionStart = 0;
            this.password.Size = new System.Drawing.Size(219, 23);
            this.password.TabIndex = 6;
            this.password.UseSystemPasswordChar = false;
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.SystemColors.Control;
            this.email.Depth = 0;
            this.email.Hint = "";
            this.email.Location = new System.Drawing.Point(255, 39);
            this.email.MouseState = MaterialSkin.MouseState.HOVER;
            this.email.Name = "email";
            this.email.PasswordChar = '\0';
            this.email.SelectedText = "";
            this.email.SelectionLength = 0;
            this.email.SelectionStart = 0;
            this.email.Size = new System.Drawing.Size(219, 23);
            this.email.TabIndex = 5;
            this.email.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(158, 91);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(79, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Password:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(182, 43);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(51, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Email:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabPage2.Controls.Add(this.infoConnessione);
            this.tabPage2.Controls.Add(this.connetti);
            this.tabPage2.Controls.Add(this.passwordDatabase);
            this.tabPage2.Controls.Add(this.username);
            this.tabPage2.Controls.Add(this.materialLabel6);
            this.tabPage2.Controls.Add(this.materialLabel7);
            this.tabPage2.Controls.Add(this.database);
            this.tabPage2.Controls.Add(this.server);
            this.tabPage2.Controls.Add(this.materialLabel4);
            this.tabPage2.Controls.Add(this.materialLabel5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(592, 275);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DATABASE";
            // 
            // passwordDatabase
            // 
            this.passwordDatabase.BackColor = System.Drawing.SystemColors.Control;
            this.passwordDatabase.Depth = 0;
            this.passwordDatabase.Hint = "";
            this.passwordDatabase.Location = new System.Drawing.Point(243, 177);
            this.passwordDatabase.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordDatabase.Name = "passwordDatabase";
            this.passwordDatabase.PasswordChar = '\0';
            this.passwordDatabase.SelectedText = "";
            this.passwordDatabase.SelectionLength = 0;
            this.passwordDatabase.SelectionStart = 0;
            this.passwordDatabase.Size = new System.Drawing.Size(219, 23);
            this.passwordDatabase.TabIndex = 14;
            this.passwordDatabase.UseSystemPasswordChar = false;
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.SystemColors.Control;
            this.username.Depth = 0;
            this.username.Hint = "";
            this.username.Location = new System.Drawing.Point(243, 129);
            this.username.MouseState = MaterialSkin.MouseState.HOVER;
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.SelectedText = "";
            this.username.SelectionLength = 0;
            this.username.SelectionStart = 0;
            this.username.Size = new System.Drawing.Size(219, 23);
            this.username.TabIndex = 13;
            this.username.Text = "root";
            this.username.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(146, 181);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(79, 19);
            this.materialLabel6.TabIndex = 12;
            this.materialLabel6.Text = "Password:";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(140, 133);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(81, 19);
            this.materialLabel7.TabIndex = 11;
            this.materialLabel7.Text = "Username:";
            // 
            // database
            // 
            this.database.BackColor = System.Drawing.SystemColors.Control;
            this.database.Depth = 0;
            this.database.Hint = "";
            this.database.Location = new System.Drawing.Point(243, 82);
            this.database.MouseState = MaterialSkin.MouseState.HOVER;
            this.database.Name = "database";
            this.database.PasswordChar = '\0';
            this.database.SelectedText = "";
            this.database.SelectionLength = 0;
            this.database.SelectionStart = 0;
            this.database.Size = new System.Drawing.Size(219, 23);
            this.database.TabIndex = 10;
            this.database.Text = "esami ecdl";
            this.database.UseSystemPasswordChar = false;
            // 
            // server
            // 
            this.server.BackColor = System.Drawing.SystemColors.Control;
            this.server.Depth = 0;
            this.server.Hint = "";
            this.server.Location = new System.Drawing.Point(243, 34);
            this.server.MouseState = MaterialSkin.MouseState.HOVER;
            this.server.Name = "server";
            this.server.PasswordChar = '\0';
            this.server.SelectedText = "";
            this.server.SelectionLength = 0;
            this.server.SelectionStart = 0;
            this.server.Size = new System.Drawing.Size(219, 23);
            this.server.TabIndex = 9;
            this.server.Text = "127.0.0.1";
            this.server.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(145, 86);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(76, 19);
            this.materialLabel4.TabIndex = 8;
            this.materialLabel4.Text = "Database:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(166, 38);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(55, 19);
            this.materialLabel5.TabIndex = 7;
            this.materialLabel5.Text = "Server:";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 61);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(801, 34);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(239, 108);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(95, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "ESAMI ECDL";
            // 
            // connetti
            // 
            this.connetti.Location = new System.Drawing.Point(227, 226);
            this.connetti.Name = "connetti";
            this.connetti.Size = new System.Drawing.Size(121, 36);
            this.connetti.TabIndex = 15;
            this.connetti.Text = "CONNETTI";
            this.connetti.UseVisualStyleBackColor = true;
            this.connetti.Click += new System.EventHandler(this.connetti_Click);
            // 
            // infoConnessione
            // 
            this.infoConnessione.AutoSize = true;
            this.infoConnessione.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoConnessione.ForeColor = System.Drawing.Color.Black;
            this.infoConnessione.Location = new System.Drawing.Point(224, 13);
            this.infoConnessione.Name = "infoConnessione";
            this.infoConnessione.Size = new System.Drawing.Size(46, 18);
            this.infoConnessione.TabIndex = 16;
            this.infoConnessione.Text = "label1";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 420);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Button inscriviti;
        private System.Windows.Forms.Button accedi;
        private MaterialSkin.Controls.MaterialSingleLineTextField password;
        private MaterialSkin.Controls.MaterialSingleLineTextField email;
        private MaterialSkin.Controls.MaterialSingleLineTextField passwordDatabase;
        private MaterialSkin.Controls.MaterialSingleLineTextField username;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSingleLineTextField database;
        private MaterialSkin.Controls.MaterialSingleLineTextField server;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.Button connetti;
        private System.Windows.Forms.Label infoConnessione;
    }
}

