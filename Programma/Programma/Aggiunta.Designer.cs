namespace Programma
{
    partial class Aggiunta
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
            this.lblSessione = new MaterialSkin.Controls.MaterialLabel();
            this.lblEsame = new MaterialSkin.Controls.MaterialLabel();
            this.txtDurata = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.btnConferma = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(13, 75);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(75, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Sessione:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(13, 111);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(59, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Esame:";
            // 
            // lblSessione
            // 
            this.lblSessione.AutoSize = true;
            this.lblSessione.Depth = 0;
            this.lblSessione.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSessione.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSessione.Location = new System.Drawing.Point(137, 82);
            this.lblSessione.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSessione.Name = "lblSessione";
            this.lblSessione.Size = new System.Drawing.Size(0, 19);
            this.lblSessione.TabIndex = 2;
            // 
            // lblEsame
            // 
            this.lblEsame.AutoSize = true;
            this.lblEsame.Depth = 0;
            this.lblEsame.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEsame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEsame.Location = new System.Drawing.Point(137, 113);
            this.lblEsame.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEsame.Name = "lblEsame";
            this.lblEsame.Size = new System.Drawing.Size(0, 19);
            this.lblEsame.TabIndex = 3;
            // 
            // txtDurata
            // 
            this.txtDurata.Depth = 0;
            this.txtDurata.Hint = "";
            this.txtDurata.Location = new System.Drawing.Point(132, 161);
            this.txtDurata.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDurata.Name = "txtDurata";
            this.txtDurata.PasswordChar = '\0';
            this.txtDurata.SelectedText = "";
            this.txtDurata.SelectionLength = 0;
            this.txtDurata.SelectionStart = 0;
            this.txtDurata.Size = new System.Drawing.Size(151, 23);
            this.txtDurata.TabIndex = 4;
            this.txtDurata.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(12, 161);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(86, 19);
            this.materialLabel5.TabIndex = 5;
            this.materialLabel5.Text = "Durata[h:m]";
            // 
            // btnConferma
            // 
            this.btnConferma.AutoSize = true;
            this.btnConferma.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConferma.Depth = 0;
            this.btnConferma.Location = new System.Drawing.Point(116, 205);
            this.btnConferma.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConferma.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Primary = false;
            this.btnConferma.Size = new System.Drawing.Size(85, 36);
            this.btnConferma.TabIndex = 6;
            this.btnConferma.Text = "Conferma";
            this.btnConferma.UseVisualStyleBackColor = true;
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // Aggiunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 256);
            this.Controls.Add(this.btnConferma);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.txtDurata);
            this.Controls.Add(this.lblEsame);
            this.Controls.Add(this.lblSessione);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "Aggiunta";
            this.Text = "Aggiunta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel lblSessione;
        private MaterialSkin.Controls.MaterialLabel lblEsame;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDurata;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialFlatButton btnConferma;
    }
}