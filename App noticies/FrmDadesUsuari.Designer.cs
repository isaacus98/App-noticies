namespace App_noticies
{
    partial class FrmDadesUsuari
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
            this.PnDadesUsuari = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PnDadesUsuari.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnDadesUsuari
            // 
            this.PnDadesUsuari.BackColor = System.Drawing.Color.White;
            this.PnDadesUsuari.Controls.Add(this.label1);
            this.PnDadesUsuari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnDadesUsuari.Location = new System.Drawing.Point(0, 0);
            this.PnDadesUsuari.Margin = new System.Windows.Forms.Padding(2);
            this.PnDadesUsuari.Name = "PnDadesUsuari";
            this.PnDadesUsuari.Size = new System.Drawing.Size(1735, 976);
            this.PnDadesUsuari.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(497, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dades Usuari";
            // 
            // FrmDadesUsuari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1735, 976);
            this.Controls.Add(this.PnDadesUsuari);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmDadesUsuari";
            this.Text = "App noticies";
            this.PnDadesUsuari.ResumeLayout(false);
            this.PnDadesUsuari.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnDadesUsuari;
        private System.Windows.Forms.Label label1;
    }
}

