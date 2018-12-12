namespace Programma
{
    partial class Login
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
            this.connetti = new System.Windows.Forms.Button();
            this.server = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.database = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.user = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // connetti
            // 
            this.connetti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connetti.Location = new System.Drawing.Point(179, 252);
            this.connetti.Name = "connetti";
            this.connetti.Size = new System.Drawing.Size(105, 32);
            this.connetti.TabIndex = 6;
            this.connetti.Text = "Connetti";
            this.connetti.UseVisualStyleBackColor = true;
            this.connetti.Click += new System.EventHandler(this.connetti_Click);
            // 
            // server
            // 
            this.server.Depth = 0;
            this.server.Hint = "";
            this.server.Location = new System.Drawing.Point(200, 83);
            this.server.MouseState = MaterialSkin.MouseState.HOVER;
            this.server.Name = "server";
            this.server.PasswordChar = '\0';
            this.server.SelectedText = "";
            this.server.SelectionLength = 0;
            this.server.SelectionStart = 0;
            this.server.Size = new System.Drawing.Size(201, 23);
            this.server.TabIndex = 7;
            this.server.Text = "127.0.0.1";
            this.server.UseSystemPasswordChar = false;
            // 
            // database
            // 
            this.database.Depth = 0;
            this.database.Hint = "";
            this.database.Location = new System.Drawing.Point(200, 124);
            this.database.MouseState = MaterialSkin.MouseState.HOVER;
            this.database.Name = "database";
            this.database.PasswordChar = '\0';
            this.database.SelectedText = "";
            this.database.SelectionLength = 0;
            this.database.SelectionStart = 0;
            this.database.Size = new System.Drawing.Size(201, 23);
            this.database.TabIndex = 8;
            this.database.Text = "esami ecdl";
            this.database.UseSystemPasswordChar = false;
            // 
            // user
            // 
            this.user.Depth = 0;
            this.user.Hint = "";
            this.user.Location = new System.Drawing.Point(200, 165);
            this.user.MouseState = MaterialSkin.MouseState.HOVER;
            this.user.Name = "user";
            this.user.PasswordChar = '\0';
            this.user.SelectedText = "";
            this.user.SelectionLength = 0;
            this.user.SelectionStart = 0;
            this.user.Size = new System.Drawing.Size(201, 23);
            this.user.TabIndex = 9;
            this.user.Text = "root";
            this.user.UseSystemPasswordChar = false;
            // 
            // password
            // 
            this.password.Depth = 0;
            this.password.Hint = "";
            this.password.Location = new System.Drawing.Point(200, 205);
            this.password.MouseState = MaterialSkin.MouseState.HOVER;
            this.password.Name = "password";
            this.password.PasswordChar = '\0';
            this.password.SelectedText = "";
            this.password.SelectionLength = 0;
            this.password.SelectionStart = 0;
            this.password.Size = new System.Drawing.Size(201, 23);
            this.password.TabIndex = 10;
            this.password.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(55, 87);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(68, 19);
            this.materialLabel1.TabIndex = 11;
            this.materialLabel1.Text = "SERVER:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(55, 128);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(89, 19);
            this.materialLabel2.TabIndex = 12;
            this.materialLabel2.Text = "DATABASE:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(55, 169);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(97, 19);
            this.materialLabel3.TabIndex = 13;
            this.materialLabel3.Text = "USER NAME:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(55, 209);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(92, 19);
            this.materialLabel4.TabIndex = 14;
            this.materialLabel4.Text = "PASSWORD:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(480, 300);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user);
            this.Controls.Add(this.database);
            this.Controls.Add(this.server);
            this.Controls.Add(this.connetti);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button connetti;
        private MaterialSkin.Controls.MaterialSingleLineTextField server;
        private MaterialSkin.Controls.MaterialSingleLineTextField database;
        private MaterialSkin.Controls.MaterialSingleLineTextField user;
        private MaterialSkin.Controls.MaterialSingleLineTextField password;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}