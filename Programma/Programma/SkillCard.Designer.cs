namespace Programma
{
    partial class SkillCard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMan = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAuto = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnConfermaCreazione = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMan);
            this.panel1.Controls.Add(this.btnAuto);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Location = new System.Drawing.Point(12, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 264);
            this.panel1.TabIndex = 0;
            // 
            // btnMan
            // 
            this.btnMan.AutoSize = true;
            this.btnMan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMan.Depth = 0;
            this.btnMan.Location = new System.Drawing.Point(84, 152);
            this.btnMan.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMan.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMan.Name = "btnMan";
            this.btnMan.Primary = false;
            this.btnMan.Size = new System.Drawing.Size(153, 36);
            this.btnMan.TabIndex = 4;
            this.btnMan.Text = "Creazione Manuale";
            this.btnMan.UseVisualStyleBackColor = true;
            this.btnMan.Click += new System.EventHandler(this.btnMan_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.AutoSize = true;
            this.btnAuto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAuto.Depth = 0;
            this.btnAuto.Location = new System.Drawing.Point(72, 104);
            this.btnAuto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAuto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Primary = false;
            this.btnAuto.Size = new System.Drawing.Size(176, 36);
            this.btnAuto.TabIndex = 3;
            this.btnAuto.Text = "Creazione Automatica";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(10, 9);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(304, 57);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Non sono state trovate skillcard esistenti o \r\nvalide per questo utente. \r\nE\' nec" +
    "cessario crearne una di nuova";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dateTimePicker2);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.btnConfermaCreazione);
            this.panel3.Controls.Add(this.materialLabel4);
            this.panel3.Controls.Add(this.materialLabel3);
            this.panel3.Location = new System.Drawing.Point(12, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(322, 264);
            this.panel3.TabIndex = 2;
            // 
            // btnConfermaCreazione
            // 
            this.btnConfermaCreazione.AutoSize = true;
            this.btnConfermaCreazione.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConfermaCreazione.Depth = 0;
            this.btnConfermaCreazione.Location = new System.Drawing.Point(111, 190);
            this.btnConfermaCreazione.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConfermaCreazione.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConfermaCreazione.Name = "btnConfermaCreazione";
            this.btnConfermaCreazione.Primary = false;
            this.btnConfermaCreazione.Size = new System.Drawing.Size(85, 36);
            this.btnConfermaCreazione.TabIndex = 4;
            this.btnConfermaCreazione.Text = "Conferma";
            this.btnConfermaCreazione.UseVisualStyleBackColor = true;
            this.btnConfermaCreazione.Click += new System.EventHandler(this.btnConfermaCreazione_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(95, 112);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(108, 19);
            this.materialLabel4.TabIndex = 1;
            this.materialLabel4.Text = "Data Scadenza";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(95, 29);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(114, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Data emissione";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(60, 57);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.TabStop = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(60, 149);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 6;
            this.dateTimePicker2.TabStop = false;
            // 
            // SkillCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 353);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "SkillCard";
            this.Text = "SkillCard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialFlatButton btnMan;
        private MaterialSkin.Controls.MaterialFlatButton btnAuto;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialFlatButton btnConfermaCreazione;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}