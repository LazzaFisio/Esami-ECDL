﻿namespace Programma
{
    partial class Messaggio
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
            this.aggiungi = new MaterialSkin.Controls.MaterialFlatButton();
            this.modifica = new MaterialSkin.Controls.MaterialFlatButton();
            this.elimina = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(130, 88);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(253, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "CHE AZIONE DESIDERE COMPIERE?";
            // 
            // aggiungi
            // 
            this.aggiungi.AutoSize = true;
            this.aggiungi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.aggiungi.Depth = 0;
            this.aggiungi.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aggiungi.Location = new System.Drawing.Point(73, 159);
            this.aggiungi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.aggiungi.MouseState = MaterialSkin.MouseState.HOVER;
            this.aggiungi.Name = "aggiungi";
            this.aggiungi.Primary = false;
            this.aggiungi.Size = new System.Drawing.Size(76, 36);
            this.aggiungi.TabIndex = 1;
            this.aggiungi.Text = "aggiungi";
            this.aggiungi.UseVisualStyleBackColor = true;
            this.aggiungi.Click += new System.EventHandler(this.aggiungi_Click);
            // 
            // modifica
            // 
            this.modifica.AutoSize = true;
            this.modifica.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.modifica.Depth = 0;
            this.modifica.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifica.Location = new System.Drawing.Point(285, 159);
            this.modifica.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.modifica.MouseState = MaterialSkin.MouseState.HOVER;
            this.modifica.Name = "modifica";
            this.modifica.Primary = false;
            this.modifica.Size = new System.Drawing.Size(76, 36);
            this.modifica.TabIndex = 2;
            this.modifica.Text = "modifica";
            this.modifica.UseVisualStyleBackColor = true;
            this.modifica.Click += new System.EventHandler(this.modifica_Click);
            // 
            // elimina
            // 
            this.elimina.AutoSize = true;
            this.elimina.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.elimina.Depth = 0;
            this.elimina.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elimina.Location = new System.Drawing.Point(476, 159);
            this.elimina.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.elimina.MouseState = MaterialSkin.MouseState.HOVER;
            this.elimina.Name = "elimina";
            this.elimina.Primary = false;
            this.elimina.Size = new System.Drawing.Size(66, 36);
            this.elimina.TabIndex = 3;
            this.elimina.Text = "elimina";
            this.elimina.UseVisualStyleBackColor = true;
            this.elimina.Click += new System.EventHandler(this.elimina_Click);
            // 
            // Messaggio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(653, 224);
            this.Controls.Add(this.elimina);
            this.Controls.Add(this.modifica);
            this.Controls.Add(this.aggiungi);
            this.Controls.Add(this.materialLabel1);
            this.MaximizeBox = false;
            this.Name = "Messaggio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Messaggio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton aggiungi;
        private MaterialSkin.Controls.MaterialFlatButton modifica;
        private MaterialSkin.Controls.MaterialFlatButton elimina;
    }
}