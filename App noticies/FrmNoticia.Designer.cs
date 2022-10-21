namespace App_noticies
{
    partial class FrmNoticia
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
            this.components = new System.ComponentModel.Container();
            this.PnNoticia = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.PnNoticia.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnNoticia
            // 
            this.PnNoticia.BackColor = System.Drawing.Color.White;
            this.PnNoticia.Controls.Add(this.label1);
            this.PnNoticia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnNoticia.Location = new System.Drawing.Point(0, 0);
            this.PnNoticia.Margin = new System.Windows.Forms.Padding(2);
            this.PnNoticia.Name = "PnNoticia";
            this.PnNoticia.Size = new System.Drawing.Size(1735, 976);
            this.PnNoticia.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "noticia";
            // 
            // FrmNoticia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1735, 976);
            this.Controls.Add(this.PnNoticia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmNoticia";
            this.Text = "App noticies";
            this.PnNoticia.ResumeLayout(false);
            this.PnNoticia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnNoticia;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label label1;
    }
}

