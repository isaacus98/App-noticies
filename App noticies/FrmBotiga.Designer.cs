﻿namespace App_noticies
{
    partial class FrmBotiga
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnBotiga = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PnBotiga.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnBotiga
            // 
            this.PnBotiga.BackColor = System.Drawing.Color.White;
            this.PnBotiga.Controls.Add(this.label1);
            this.PnBotiga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnBotiga.Location = new System.Drawing.Point(0, 0);
            this.PnBotiga.Margin = new System.Windows.Forms.Padding(2);
            this.PnBotiga.Name = "PnBotiga";
            this.PnBotiga.Size = new System.Drawing.Size(1735, 976);
            this.PnBotiga.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "botiga";
            // 
            // FrmBotiga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1735, 976);
            this.Controls.Add(this.PnBotiga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmBotiga";
            this.Text = "App noticies";
            this.PnBotiga.ResumeLayout(false);
            this.PnBotiga.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnBotiga;
        private System.Windows.Forms.Label label1;
    }
}

