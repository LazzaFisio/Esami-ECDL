﻿namespace Programma
{
    partial class Elimina
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
            this.modifica = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnElimina = new MaterialSkin.Controls.MaterialFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.eliminaPanel = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // modifica
            // 
            this.modifica.AutoSize = true;
            this.modifica.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.modifica.Depth = 0;
            this.modifica.Location = new System.Drawing.Point(230, 571);
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
            // btnElimina
            // 
            this.btnElimina.AutoSize = true;
            this.btnElimina.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnElimina.Depth = 0;
            this.btnElimina.Location = new System.Drawing.Point(485, 571);
            this.btnElimina.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnElimina.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Primary = false;
            this.btnElimina.Size = new System.Drawing.Size(66, 36);
            this.btnElimina.TabIndex = 3;
            this.btnElimina.Text = "elimina";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "CAMPO:";
            // 
            // eliminaPanel
            // 
            this.eliminaPanel.AutoSize = true;
            this.eliminaPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.eliminaPanel.Depth = 0;
            this.eliminaPanel.Location = new System.Drawing.Point(664, 136);
            this.eliminaPanel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.eliminaPanel.MouseState = MaterialSkin.MouseState.HOVER;
            this.eliminaPanel.Name = "eliminaPanel";
            this.eliminaPanel.Primary = false;
            this.eliminaPanel.Size = new System.Drawing.Size(66, 36);
            this.eliminaPanel.TabIndex = 5;
            this.eliminaPanel.Text = "elimina";
            this.eliminaPanel.UseVisualStyleBackColor = true;
            this.eliminaPanel.Visible = false;
            this.eliminaPanel.Click += new System.EventHandler(this.eliminaPanel_Click);
            // 
            // Elimina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 624);
            this.Controls.Add(this.eliminaPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.modifica);
            this.Name = "Elimina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elimina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton modifica;
        private MaterialSkin.Controls.MaterialFlatButton btnElimina;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialFlatButton eliminaPanel;
    }
}