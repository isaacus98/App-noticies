namespace App_noticies
{
    partial class Targeta
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
            this.TxtResponsable = new PlaceholderTextBox.PlaceholderTextBox();
            this.TxtCaducitat = new PlaceholderTextBox.PlaceholderTextBox();
            this.TxtNumeroTargeta = new PlaceholderTextBox.PlaceholderTextBox();
            this.BtnConfirmarTargeta = new System.Windows.Forms.Button();
            this.TxtCvv = new PlaceholderTextBox.PlaceholderTextBox();
            this.SuspendLayout();
            // 
            // TxtResponsable
            // 
            this.TxtResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtResponsable.Location = new System.Drawing.Point(12, 49);
            this.TxtResponsable.Name = "TxtResponsable";
            this.TxtResponsable.PlaceholderText = "Nom del responsable";
            this.TxtResponsable.Size = new System.Drawing.Size(341, 31);
            this.TxtResponsable.TabIndex = 23;
            // 
            // TxtCaducitat
            // 
            this.TxtCaducitat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCaducitat.Location = new System.Drawing.Point(12, 161);
            this.TxtCaducitat.Name = "TxtCaducitat";
            this.TxtCaducitat.PlaceholderText = "Data caduscitat";
            this.TxtCaducitat.Size = new System.Drawing.Size(341, 31);
            this.TxtCaducitat.TabIndex = 24;
            // 
            // TxtNumeroTargeta
            // 
            this.TxtNumeroTargeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumeroTargeta.Location = new System.Drawing.Point(12, 115);
            this.TxtNumeroTargeta.Name = "TxtNumeroTargeta";
            this.TxtNumeroTargeta.PlaceholderText = "Numero de la targeta";
            this.TxtNumeroTargeta.Size = new System.Drawing.Size(341, 31);
            this.TxtNumeroTargeta.TabIndex = 25;
            // 
            // BtnConfirmarTargeta
            // 
            this.BtnConfirmarTargeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BtnConfirmarTargeta.Location = new System.Drawing.Point(204, 351);
            this.BtnConfirmarTargeta.Name = "BtnConfirmarTargeta";
            this.BtnConfirmarTargeta.Size = new System.Drawing.Size(135, 45);
            this.BtnConfirmarTargeta.TabIndex = 26;
            this.BtnConfirmarTargeta.Text = "Confiramar";
            this.BtnConfirmarTargeta.UseVisualStyleBackColor = true;
            this.BtnConfirmarTargeta.Click += new System.EventHandler(this.BtnConfirmarTargeta_Click);
            // 
            // TxtCvv
            // 
            this.TxtCvv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCvv.Location = new System.Drawing.Point(12, 210);
            this.TxtCvv.Name = "TxtCvv";
            this.TxtCvv.PlaceholderText = "CVV";
            this.TxtCvv.Size = new System.Drawing.Size(341, 31);
            this.TxtCvv.TabIndex = 27;
            // 
            // Targeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 450);
            this.Controls.Add(this.TxtCvv);
            this.Controls.Add(this.BtnConfirmarTargeta);
            this.Controls.Add(this.TxtNumeroTargeta);
            this.Controls.Add(this.TxtCaducitat);
            this.Controls.Add(this.TxtResponsable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Targeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Afegir targeta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PlaceholderTextBox.PlaceholderTextBox TxtResponsable;
        private PlaceholderTextBox.PlaceholderTextBox TxtCaducitat;
        private PlaceholderTextBox.PlaceholderTextBox TxtNumeroTargeta;
        private System.Windows.Forms.Button BtnConfirmarTargeta;
        private PlaceholderTextBox.PlaceholderTextBox TxtCvv;
    }
}