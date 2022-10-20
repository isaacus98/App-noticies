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
            this.components = new System.ComponentModel.Container();
            this.LbIniciSessio = new System.Windows.Forms.Label();
            this.TxtRepetirContrasenya = new Windows.Forms.HintTextBox(this.components);
            this.BtnIniciSessio = new System.Windows.Forms.Button();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.TxtUserName = new Windows.Forms.HintTextBox(this.components);
            this.TxtContrasenya = new Windows.Forms.HintTextBox(this.components);
            this.TxtNom = new Windows.Forms.HintTextBox(this.components);
            this.TxtEmail = new Windows.Forms.HintTextBox(this.components);
            this.BtnTwitter = new FontAwesome.Sharp.IconButton();
            this.BtnGoogle = new System.Windows.Forms.Button();
            this.BtnFacebook = new FontAwesome.Sharp.IconButton();
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
            // TxtRepetirContrasenya
            // 
            this.TxtRepetirContrasenya.EnterToTab = false;
            this.TxtRepetirContrasenya.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRepetirContrasenya.ForeColor = System.Drawing.Color.Gray;
            this.TxtRepetirContrasenya.HintColor = System.Drawing.Color.Gray;
            this.TxtRepetirContrasenya.HintValue = "contrasenya";
            this.TxtRepetirContrasenya.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TxtRepetirContrasenya.Location = new System.Drawing.Point(67, 180);
            this.TxtRepetirContrasenya.Name = "TxtRepetirContrasenya";
            this.TxtRepetirContrasenya.Size = new System.Drawing.Size(350, 31);
            this.TxtRepetirContrasenya.TabIndex = 6;
            this.TxtRepetirContrasenya.TextForeColor = System.Drawing.Color.Black;
            this.TxtRepetirContrasenya.UseSystemPasswordChar = true;
            this.TxtRepetirContrasenya.Value = "";
            this.TxtRepetirContrasenya.Visible = false;
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
            // TxtUserName
            // 
            this.TxtUserName.EnterToTab = false;
            this.TxtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserName.ForeColor = System.Drawing.Color.Gray;
            this.TxtUserName.HintColor = System.Drawing.Color.Gray;
            this.TxtUserName.HintValue = "Nom d\'usuari";
            this.TxtUserName.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TxtUserName.Location = new System.Drawing.Point(67, 108);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(350, 31);
            this.TxtUserName.TabIndex = 14;
            this.TxtUserName.TextForeColor = System.Drawing.Color.Black;
            this.TxtUserName.Value = "";
            // 
            // TxtContrasenya
            // 
            this.TxtContrasenya.EnterToTab = false;
            this.TxtContrasenya.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContrasenya.ForeColor = System.Drawing.Color.Gray;
            this.TxtContrasenya.HintColor = System.Drawing.Color.Gray;
            this.TxtContrasenya.HintValue = "Contrasenya";
            this.TxtContrasenya.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TxtContrasenya.Location = new System.Drawing.Point(67, 144);
            this.TxtContrasenya.Name = "TxtContrasenya";
            this.TxtContrasenya.Size = new System.Drawing.Size(350, 31);
            this.TxtContrasenya.TabIndex = 19;
            this.TxtContrasenya.TextForeColor = System.Drawing.Color.Black;
            this.TxtContrasenya.UseSystemPasswordChar = true;
            this.TxtContrasenya.Value = "";
            // 
            // TxtNom
            // 
            this.TxtNom.EnterToTab = false;
            this.TxtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNom.ForeColor = System.Drawing.Color.Gray;
            this.TxtNom.HintColor = System.Drawing.Color.Gray;
            this.TxtNom.HintValue = "Nom";
            this.TxtNom.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TxtNom.Location = new System.Drawing.Point(67, 252);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(350, 31);
            this.TxtNom.TabIndex = 20;
            this.TxtNom.TextForeColor = System.Drawing.Color.Black;
            this.TxtNom.Value = "";
            this.TxtNom.Visible = false;
            // 
            // TxtEmail
            // 
            this.TxtEmail.EnterToTab = false;
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.ForeColor = System.Drawing.Color.Gray;
            this.TxtEmail.HintColor = System.Drawing.Color.Gray;
            this.TxtEmail.HintValue = "Correu electrónic";
            this.TxtEmail.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TxtEmail.Location = new System.Drawing.Point(67, 216);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(350, 31);
            this.TxtEmail.TabIndex = 21;
            this.TxtEmail.TextForeColor = System.Drawing.Color.Black;
            this.TxtEmail.Value = "";
            this.TxtEmail.Visible = false;
            // 
            // BtnTwitter
            // 
            this.BtnTwitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BtnTwitter.IconChar = FontAwesome.Sharp.IconChar.Twitter;
            this.BtnTwitter.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(140)))), ((int)(((byte)(216)))));
            this.BtnTwitter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnTwitter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTwitter.Location = new System.Drawing.Point(67, 340);
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
            this.BtnGoogle.Location = new System.Drawing.Point(67, 279);
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
            this.BtnFacebook.Location = new System.Drawing.Point(67, 216);
            this.BtnFacebook.Name = "BtnFacebook";
            this.BtnFacebook.Size = new System.Drawing.Size(350, 56);
            this.BtnFacebook.TabIndex = 15;
            this.BtnFacebook.Text = "Continua amb Facebook";
            this.BtnFacebook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFacebook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFacebook.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 536);
            this.Controls.Add(this.BtnTwitter);
            this.Controls.Add(this.BtnGoogle);
            this.Controls.Add(this.BtnFacebook);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtNom);
            this.Controls.Add(this.TxtContrasenya);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.BtnIniciSessio);
            this.Controls.Add(this.TxtRepetirContrasenya);
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
        private Windows.Forms.HintTextBox TxtRepetirContrasenya;
        private System.Windows.Forms.Button BtnIniciSessio;
        private System.Windows.Forms.Button BtnRegistrar;
        private Windows.Forms.HintTextBox TxtUserName;
        private FontAwesome.Sharp.IconButton BtnFacebook;
        private System.Windows.Forms.Button BtnGoogle;
        private FontAwesome.Sharp.IconButton BtnTwitter;
        private Windows.Forms.HintTextBox TxtContrasenya;
        private Windows.Forms.HintTextBox TxtNom;
        private Windows.Forms.HintTextBox TxtEmail;
    }
}