namespace Programma
{
    partial class Dettagli
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
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.btnConf = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtDurata = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblSessione = new MaterialSkin.Controls.MaterialLabel();
            this.lblEsame = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(13, 111);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(86, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Id sessione";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(13, 148);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(70, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Id esame";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(13, 192);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(53, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Durata";
            // 
            // btnConf
            // 
            this.btnConf.AutoSize = true;
            this.btnConf.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConf.Depth = 0;
            this.btnConf.Location = new System.Drawing.Point(113, 251);
            this.btnConf.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConf.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConf.Name = "btnConf";
            this.btnConf.Primary = false;
            this.btnConf.Size = new System.Drawing.Size(85, 36);
            this.btnConf.TabIndex = 3;
            this.btnConf.Text = "Conferma";
            this.btnConf.UseVisualStyleBackColor = true;
            this.btnConf.Click += new System.EventHandler(this.btnConf_Click);
            // 
            // txtDurata
            // 
            this.txtDurata.BackColor = System.Drawing.SystemColors.Control;
            this.txtDurata.Depth = 0;
            this.txtDurata.Hint = "";
            this.txtDurata.Location = new System.Drawing.Point(148, 192);
            this.txtDurata.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDurata.Name = "txtDurata";
            this.txtDurata.PasswordChar = '\0';
            this.txtDurata.SelectedText = "";
            this.txtDurata.SelectionLength = 0;
            this.txtDurata.SelectionStart = 0;
            this.txtDurata.Size = new System.Drawing.Size(147, 23);
            this.txtDurata.TabIndex = 4;
            this.txtDurata.UseSystemPasswordChar = false;
            // 
            // lblSessione
            // 
            this.lblSessione.AutoSize = true;
            this.lblSessione.Depth = 0;
            this.lblSessione.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSessione.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSessione.Location = new System.Drawing.Point(157, 111);
            this.lblSessione.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSessione.Name = "lblSessione";
            this.lblSessione.Size = new System.Drawing.Size(0, 19);
            this.lblSessione.TabIndex = 5;
            // 
            // lblEsame
            // 
            this.lblEsame.AutoSize = true;
            this.lblEsame.Depth = 0;
            this.lblEsame.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEsame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEsame.Location = new System.Drawing.Point(157, 148);
            this.lblEsame.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEsame.Name = "lblEsame";
            this.lblEsame.Size = new System.Drawing.Size(0, 19);
            this.lblEsame.TabIndex = 6;
            // 
            // Dettagli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 314);
            this.Controls.Add(this.lblEsame);
            this.Controls.Add(this.lblSessione);
            this.Controls.Add(this.txtDurata);
            this.Controls.Add(this.btnConf);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "Dettagli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dettagli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialFlatButton btnConf;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDurata;
        private MaterialSkin.Controls.MaterialLabel lblSessione;
        private MaterialSkin.Controls.MaterialLabel lblEsame;
    }
}