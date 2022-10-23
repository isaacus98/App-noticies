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
            this.components = new System.ComponentModel.Container();
            this.PnDadesUsuari = new System.Windows.Forms.Panel();
            this.PnlTemes = new System.Windows.Forms.Panel();
            this.RbtnClar = new System.Windows.Forms.RadioButton();
            this.RbtnFosc = new System.Windows.Forms.RadioButton();
            this.PnlLinia = new System.Windows.Forms.FlowLayoutPanel();
            this.LblTemes = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PnDadesUsuari.SuspendLayout();
            this.PnlTemes.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnDadesUsuari
            // 
            this.PnDadesUsuari.BackColor = System.Drawing.Color.Transparent;
            this.PnDadesUsuari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PnDadesUsuari.Controls.Add(this.PnlTemes);
            this.PnDadesUsuari.Controls.Add(this.PnlLinia);
            this.PnDadesUsuari.Controls.Add(this.LblTemes);
            this.PnDadesUsuari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnDadesUsuari.Location = new System.Drawing.Point(0, 0);
            this.PnDadesUsuari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnDadesUsuari.Name = "PnDadesUsuari";
            this.PnDadesUsuari.Size = new System.Drawing.Size(1942, 1102);
            this.PnDadesUsuari.TabIndex = 2;
            // 
            // PnlTemes
            // 
            this.PnlTemes.Controls.Add(this.RbtnClar);
            this.PnlTemes.Controls.Add(this.RbtnFosc);
            this.PnlTemes.ForeColor = System.Drawing.Color.Black;
            this.PnlTemes.Location = new System.Drawing.Point(275, 176);
            this.PnlTemes.Name = "PnlTemes";
            this.PnlTemes.Size = new System.Drawing.Size(200, 100);
            this.PnlTemes.TabIndex = 4;
            this.PnlTemes.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // RbtnClar
            // 
            this.RbtnClar.AutoSize = true;
            this.RbtnClar.Location = new System.Drawing.Point(38, 18);
            this.RbtnClar.Name = "RbtnClar";
            this.RbtnClar.Size = new System.Drawing.Size(54, 21);
            this.RbtnClar.TabIndex = 2;
            this.RbtnClar.TabStop = true;
            this.RbtnClar.Text = "Clar";
            this.RbtnClar.UseVisualStyleBackColor = true;
            // 
            // RbtnFosc
            // 
            this.RbtnFosc.AutoSize = true;
            this.RbtnFosc.Location = new System.Drawing.Point(38, 54);
            this.RbtnFosc.Name = "RbtnFosc";
            this.RbtnFosc.Size = new System.Drawing.Size(59, 21);
            this.RbtnFosc.TabIndex = 3;
            this.RbtnFosc.TabStop = true;
            this.RbtnFosc.Text = "Fosc";
            this.RbtnFosc.UseVisualStyleBackColor = true;
            // 
            // PnlLinia
            // 
            this.PnlLinia.BackColor = System.Drawing.Color.Black;
            this.PnlLinia.Location = new System.Drawing.Point(243, 150);
            this.PnlLinia.Name = "PnlLinia";
            this.PnlLinia.Size = new System.Drawing.Size(1925, 1);
            this.PnlLinia.TabIndex = 1;
            // 
            // LblTemes
            // 
            this.LblTemes.AutoSize = true;
            this.LblTemes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.LblTemes.Location = new System.Drawing.Point(300, 90);
            this.LblTemes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTemes.Name = "LblTemes";
            this.LblTemes.Size = new System.Drawing.Size(126, 39);
            this.LblTemes.TabIndex = 0;
            this.LblTemes.Text = "Temes";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmDadesUsuari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.PnDadesUsuari);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmDadesUsuari";
            this.Text = "App noticies";
            this.PnDadesUsuari.ResumeLayout(false);
            this.PnDadesUsuari.PerformLayout();
            this.PnlTemes.ResumeLayout(false);
            this.PnlTemes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnDadesUsuari;
        private System.Windows.Forms.Label LblTemes;
        private System.Windows.Forms.FlowLayoutPanel PnlLinia;
        private System.Windows.Forms.RadioButton RbtnFosc;
        private System.Windows.Forms.RadioButton RbtnClar;
        private System.Windows.Forms.Panel PnlTemes;
        private System.Windows.Forms.Timer timer1;
    }
}

