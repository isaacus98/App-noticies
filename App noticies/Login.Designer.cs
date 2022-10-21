namespace App_noticies
{
    partial class Login
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
            this.LbIniciSessio = new System.Windows.Forms.Label();
            this.BtnIniciSessio = new System.Windows.Forms.Button();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.BtnTwitter = new FontAwesome.Sharp.IconButton();
            this.BtnGoogle = new System.Windows.Forms.Button();
            this.BtnFacebook = new FontAwesome.Sharp.IconButton();
            this.TxtUserName = new PlaceholderTextBox.PlaceholderTextBox();
            this.TxtContrasenya = new PlaceholderTextBox.PlaceholderTextBox();
            this.TxtRepetirContrasenya = new PlaceholderTextBox.PlaceholderTextBox();
            this.TxtEmail = new PlaceholderTextBox.PlaceholderTextBox();
            this.TxtNom = new PlaceholderTextBox.PlaceholderTextBox();
            this.SuspendLayout();
            // 
            // LbIniciSessio
            // 
            this.LbIniciSessio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LbIniciSessio.AutoSize = true;
            this.LbIniciSessio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.LbIniciSessio.ForeColor = System.Drawing.SystemColors.MenuText;
            this.LbIniciSessio.Location = new System.Drawing.Point(147, 49);
            this.LbIniciSessio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbIniciSessio.Name = "LbIniciSessio";
            this.LbIniciSessio.Size = new System.Drawing.Size(199, 24);
            this.LbIniciSessio.TabIndex = 4;
            this.LbIniciSessio.Text = "Iniciar Sessió/Registrar";
            // 
            // BtnIniciSessio
            // 
            this.BtnIniciSessio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BtnIniciSessio.Location = new System.Drawing.Point(282, 440);
            this.BtnIniciSessio.Name = "BtnIniciSessio";
            this.BtnIniciSessio.Size = new System.Drawing.Size(135, 45);
            this.BtnIniciSessio.TabIndex = 11;
            this.BtnIniciSessio.Text = "Iniciar Sessió";
            this.BtnIniciSessio.UseVisualStyleBackColor = true;
            this.BtnIniciSessio.Click += new System.EventHandler(this.BtnIniciSessio_Click);
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BtnRegistrar.Location = new System.Drawing.Point(67, 440);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(135, 45);
            this.BtnRegistrar.TabIndex = 12;
            this.BtnRegistrar.Text = "Registrar-se";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnTwitter
            // 
            this.BtnTwitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BtnTwitter.IconChar = FontAwesome.Sharp.IconChar.Twitter;
            this.BtnTwitter.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(140)))), ((int)(((byte)(216)))));
            this.BtnTwitter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnTwitter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTwitter.Location = new System.Drawing.Point(67, 318);
            this.BtnTwitter.Name = "BtnTwitter";
            this.BtnTwitter.Size = new System.Drawing.Size(350, 56);
            this.BtnTwitter.TabIndex = 18;
            this.BtnTwitter.Text = "Continua amb Twitter";
            this.BtnTwitter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTwitter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnTwitter.UseVisualStyleBackColor = true;
            // 
            // BtnGoogle
            // 
            this.BtnGoogle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BtnGoogle.Image = global::App_noticies.Properties.Resources.GoogleIcon;
            this.BtnGoogle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGoogle.Location = new System.Drawing.Point(67, 257);
            this.BtnGoogle.Name = "BtnGoogle";
            this.BtnGoogle.Size = new System.Drawing.Size(350, 56);
            this.BtnGoogle.TabIndex = 17;
            this.BtnGoogle.Text = "Continua amb Google";
            this.BtnGoogle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGoogle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGoogle.UseVisualStyleBackColor = true;
            // 
            // BtnFacebook
            // 
            this.BtnFacebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BtnFacebook.IconChar = FontAwesome.Sharp.IconChar.Facebook;
            this.BtnFacebook.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(111)))), ((int)(((byte)(229)))));
            this.BtnFacebook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnFacebook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFacebook.Location = new System.Drawing.Point(67, 194);
            this.BtnFacebook.Name = "BtnFacebook";
            this.BtnFacebook.Size = new System.Drawing.Size(350, 56);
            this.BtnFacebook.TabIndex = 15;
            this.BtnFacebook.Text = "Continua amb Facebook";
            this.BtnFacebook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFacebook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFacebook.UseVisualStyleBackColor = true;
            // 
            // TxtUserName
            // 
            this.TxtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserName.Location = new System.Drawing.Point(67, 107);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.PlaceholderText = "Nom d\'usuari";
            this.TxtUserName.Size = new System.Drawing.Size(350, 31);
            this.TxtUserName.TabIndex = 22;
            // 
            // TxtContrasenya
            // 
            this.TxtContrasenya.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContrasenya.Location = new System.Drawing.Point(67, 145);
            this.TxtContrasenya.Name = "TxtContrasenya";
            this.TxtContrasenya.PlaceholderText = "Contrasenya";
            this.TxtContrasenya.Size = new System.Drawing.Size(350, 31);
            this.TxtContrasenya.TabIndex = 23;
            this.TxtContrasenya.UseSystemPasswordChar = true;
            // 
            // TxtRepetirContrasenya
            // 
            this.TxtRepetirContrasenya.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRepetirContrasenya.Location = new System.Drawing.Point(67, 182);
            this.TxtRepetirContrasenya.Name = "TxtRepetirContrasenya";
            this.TxtRepetirContrasenya.PlaceholderText = "Contrasenya";
            this.TxtRepetirContrasenya.Size = new System.Drawing.Size(350, 31);
            this.TxtRepetirContrasenya.TabIndex = 24;
            this.TxtRepetirContrasenya.UseSystemPasswordChar = true;
            this.TxtRepetirContrasenya.Visible = false;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(67, 219);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.PlaceholderText = "Correu electrónic";
            this.TxtEmail.Size = new System.Drawing.Size(350, 31);
            this.TxtEmail.TabIndex = 26;
            this.TxtEmail.Visible = false;
            // 
            // TxtNom
            // 
            this.TxtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNom.Location = new System.Drawing.Point(67, 256);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.PlaceholderText = "Nom";
            this.TxtNom.Size = new System.Drawing.Size(350, 31);
            this.TxtNom.TabIndex = 27;
            this.TxtNom.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 536);
            this.Controls.Add(this.BtnTwitter);
            this.Controls.Add(this.BtnGoogle);
            this.Controls.Add(this.BtnFacebook);
            this.Controls.Add(this.TxtNom);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtRepetirContrasenya);
            this.Controls.Add(this.TxtContrasenya);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.BtnIniciSessio);
            this.Controls.Add(this.LbIniciSessio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LbIniciSessio;
        private System.Windows.Forms.Button BtnIniciSessio;
        private System.Windows.Forms.Button BtnRegistrar;
        private FontAwesome.Sharp.IconButton BtnFacebook;
        private System.Windows.Forms.Button BtnGoogle;
        private FontAwesome.Sharp.IconButton BtnTwitter;
        private PlaceholderTextBox.PlaceholderTextBox TxtUserName;
        private PlaceholderTextBox.PlaceholderTextBox TxtContrasenya;
        private PlaceholderTextBox.PlaceholderTextBox TxtRepetirContrasenya;
        private PlaceholderTextBox.PlaceholderTextBox TxtEmail;
        private PlaceholderTextBox.PlaceholderTextBox TxtNom;
    }
}