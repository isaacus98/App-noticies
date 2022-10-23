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
            this.BtnAfegirTag = new System.Windows.Forms.Button();
            this.TxtListTags = new PlaceholderTextBox.PlaceholderTextBox();
            this.TxtTags = new PlaceholderTextBox.PlaceholderTextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.LblTags = new System.Windows.Forms.Label();
            this.BtnConfirmarDades = new System.Windows.Forms.Button();
            this.TxtDireccio = new PlaceholderTextBox.PlaceholderTextBox();
            this.TxtCognom = new PlaceholderTextBox.PlaceholderTextBox();
            this.TxtNom = new PlaceholderTextBox.PlaceholderTextBox();
            this.TxtRepetirContrassenya = new PlaceholderTextBox.PlaceholderTextBox();
            this.TxtContrasenya = new PlaceholderTextBox.PlaceholderTextBox();
            this.TxtEmail = new PlaceholderTextBox.PlaceholderTextBox();
            this.TxtUserName = new PlaceholderTextBox.PlaceholderTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LblDadesUsuari = new System.Windows.Forms.Label();
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
            this.PnDadesUsuari.Controls.Add(this.BtnAfegirTag);
            this.PnDadesUsuari.Controls.Add(this.TxtListTags);
            this.PnDadesUsuari.Controls.Add(this.TxtTags);
            this.PnDadesUsuari.Controls.Add(this.flowLayoutPanel2);
            this.PnDadesUsuari.Controls.Add(this.LblTags);
            this.PnDadesUsuari.Controls.Add(this.BtnConfirmarDades);
            this.PnDadesUsuari.Controls.Add(this.TxtDireccio);
            this.PnDadesUsuari.Controls.Add(this.TxtCognom);
            this.PnDadesUsuari.Controls.Add(this.TxtNom);
            this.PnDadesUsuari.Controls.Add(this.TxtRepetirContrassenya);
            this.PnDadesUsuari.Controls.Add(this.TxtContrasenya);
            this.PnDadesUsuari.Controls.Add(this.TxtEmail);
            this.PnDadesUsuari.Controls.Add(this.TxtUserName);
            this.PnDadesUsuari.Controls.Add(this.flowLayoutPanel1);
            this.PnDadesUsuari.Controls.Add(this.LblDadesUsuari);
            this.PnDadesUsuari.Controls.Add(this.PnlTemes);
            this.PnDadesUsuari.Controls.Add(this.PnlLinia);
            this.PnDadesUsuari.Controls.Add(this.LblTemes);
            this.PnDadesUsuari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnDadesUsuari.Location = new System.Drawing.Point(0, 0);
            this.PnDadesUsuari.Margin = new System.Windows.Forms.Padding(2);
            this.PnDadesUsuari.Name = "PnDadesUsuari";
            this.PnDadesUsuari.Size = new System.Drawing.Size(1456, 894);
            this.PnDadesUsuari.TabIndex = 2;
            // 
            // BtnAfegirTag
            // 
            this.BtnAfegirTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BtnAfegirTag.Location = new System.Drawing.Point(562, 313);
            this.BtnAfegirTag.Name = "BtnAfegirTag";
            this.BtnAfegirTag.Size = new System.Drawing.Size(123, 31);
            this.BtnAfegirTag.TabIndex = 38;
            this.BtnAfegirTag.Text = "Afegir";
            this.BtnAfegirTag.UseVisualStyleBackColor = true;
            this.BtnAfegirTag.Click += new System.EventHandler(this.BtnAfegirTag_Click);
            // 
            // TxtListTags
            // 
            this.TxtListTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtListTags.Location = new System.Drawing.Point(206, 350);
            this.TxtListTags.Multiline = true;
            this.TxtListTags.Name = "TxtListTags";
            this.TxtListTags.PlaceholderText = "Tags";
            this.TxtListTags.ReadOnly = true;
            this.TxtListTags.Size = new System.Drawing.Size(350, 87);
            this.TxtListTags.TabIndex = 37;
            // 
            // TxtTags
            // 
            this.TxtTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTags.Location = new System.Drawing.Point(206, 313);
            this.TxtTags.Name = "TxtTags";
            this.TxtTags.PlaceholderText = "Tags";
            this.TxtTags.Size = new System.Drawing.Size(350, 31);
            this.TxtTags.TabIndex = 36;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(182, 307);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1444, 1);
            this.flowLayoutPanel2.TabIndex = 35;
            // 
            // LblTags
            // 
            this.LblTags.AutoSize = true;
            this.LblTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.LblTags.Location = new System.Drawing.Point(225, 258);
            this.LblTags.Name = "LblTags";
            this.LblTags.Size = new System.Drawing.Size(79, 31);
            this.LblTags.TabIndex = 34;
            this.LblTags.Text = "Tags";
            // 
            // BtnConfirmarDades
            // 
            this.BtnConfirmarDades.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BtnConfirmarDades.Location = new System.Drawing.Point(450, 793);
            this.BtnConfirmarDades.Name = "BtnConfirmarDades";
            this.BtnConfirmarDades.Size = new System.Drawing.Size(106, 36);
            this.BtnConfirmarDades.TabIndex = 33;
            this.BtnConfirmarDades.Text = "Confirmar";
            this.BtnConfirmarDades.UseVisualStyleBackColor = true;
            this.BtnConfirmarDades.Click += new System.EventHandler(this.BtnConfirmarDades_Click);
            // 
            // TxtDireccio
            // 
            this.TxtDireccio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccio.Location = new System.Drawing.Point(206, 747);
            this.TxtDireccio.Name = "TxtDireccio";
            this.TxtDireccio.PlaceholderText = "Direcció";
            this.TxtDireccio.Size = new System.Drawing.Size(350, 31);
            this.TxtDireccio.TabIndex = 32;
            // 
            // TxtCognom
            // 
            this.TxtCognom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCognom.Location = new System.Drawing.Point(206, 710);
            this.TxtCognom.Name = "TxtCognom";
            this.TxtCognom.PlaceholderText = "Cognom";
            this.TxtCognom.Size = new System.Drawing.Size(350, 31);
            this.TxtCognom.TabIndex = 31;
            // 
            // TxtNom
            // 
            this.TxtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNom.Location = new System.Drawing.Point(206, 673);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.PlaceholderText = "Nom";
            this.TxtNom.Size = new System.Drawing.Size(350, 31);
            this.TxtNom.TabIndex = 30;
            // 
            // TxtRepetirContrassenya
            // 
            this.TxtRepetirContrassenya.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRepetirContrassenya.Location = new System.Drawing.Point(206, 636);
            this.TxtRepetirContrassenya.Name = "TxtRepetirContrassenya";
            this.TxtRepetirContrassenya.PlaceholderText = "Contrasenya";
            this.TxtRepetirContrassenya.Size = new System.Drawing.Size(350, 31);
            this.TxtRepetirContrassenya.TabIndex = 29;
            this.TxtRepetirContrassenya.UseSystemPasswordChar = true;
            // 
            // TxtContrasenya
            // 
            this.TxtContrasenya.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContrasenya.Location = new System.Drawing.Point(206, 599);
            this.TxtContrasenya.Name = "TxtContrasenya";
            this.TxtContrasenya.PlaceholderText = "Contrasenya";
            this.TxtContrasenya.Size = new System.Drawing.Size(350, 31);
            this.TxtContrasenya.TabIndex = 28;
            this.TxtContrasenya.UseSystemPasswordChar = true;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(206, 562);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.PlaceholderText = "Correu electrónic";
            this.TxtEmail.Size = new System.Drawing.Size(350, 31);
            this.TxtEmail.TabIndex = 27;
            // 
            // TxtUserName
            // 
            this.TxtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserName.Location = new System.Drawing.Point(206, 525);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.PlaceholderText = "Nom d\'usuari";
            this.TxtUserName.Size = new System.Drawing.Size(350, 31);
            this.TxtUserName.TabIndex = 23;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(182, 505);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1444, 1);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // LblDadesUsuari
            // 
            this.LblDadesUsuari.AutoSize = true;
            this.LblDadesUsuari.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.LblDadesUsuari.Location = new System.Drawing.Point(225, 456);
            this.LblDadesUsuari.Name = "LblDadesUsuari";
            this.LblDadesUsuari.Size = new System.Drawing.Size(208, 31);
            this.LblDadesUsuari.TabIndex = 5;
            this.LblDadesUsuari.Text = "Dades d\'usuari";
            // 
            // PnlTemes
            // 
            this.PnlTemes.Controls.Add(this.RbtnClar);
            this.PnlTemes.Controls.Add(this.RbtnFosc);
            this.PnlTemes.ForeColor = System.Drawing.Color.Black;
            this.PnlTemes.Location = new System.Drawing.Point(206, 143);
            this.PnlTemes.Margin = new System.Windows.Forms.Padding(2);
            this.PnlTemes.Name = "PnlTemes";
            this.PnlTemes.Size = new System.Drawing.Size(150, 81);
            this.PnlTemes.TabIndex = 4;
            this.PnlTemes.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // RbtnClar
            // 
            this.RbtnClar.AutoSize = true;
            this.RbtnClar.Location = new System.Drawing.Point(28, 15);
            this.RbtnClar.Margin = new System.Windows.Forms.Padding(2);
            this.RbtnClar.Name = "RbtnClar";
            this.RbtnClar.Size = new System.Drawing.Size(43, 17);
            this.RbtnClar.TabIndex = 2;
            this.RbtnClar.TabStop = true;
            this.RbtnClar.Text = "Clar";
            this.RbtnClar.UseVisualStyleBackColor = true;
            // 
            // RbtnFosc
            // 
            this.RbtnFosc.AutoSize = true;
            this.RbtnFosc.Location = new System.Drawing.Point(28, 44);
            this.RbtnFosc.Margin = new System.Windows.Forms.Padding(2);
            this.RbtnFosc.Name = "RbtnFosc";
            this.RbtnFosc.Size = new System.Drawing.Size(48, 17);
            this.RbtnFosc.TabIndex = 3;
            this.RbtnFosc.TabStop = true;
            this.RbtnFosc.Text = "Fosc";
            this.RbtnFosc.UseVisualStyleBackColor = true;
            // 
            // PnlLinia
            // 
            this.PnlLinia.BackColor = System.Drawing.Color.Black;
            this.PnlLinia.Location = new System.Drawing.Point(182, 122);
            this.PnlLinia.Margin = new System.Windows.Forms.Padding(2);
            this.PnlLinia.Name = "PnlLinia";
            this.PnlLinia.Size = new System.Drawing.Size(1444, 1);
            this.PnlLinia.TabIndex = 1;
            // 
            // LblTemes
            // 
            this.LblTemes.AutoSize = true;
            this.LblTemes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.LblTemes.Location = new System.Drawing.Point(225, 73);
            this.LblTemes.Name = "LblTemes";
            this.LblTemes.Size = new System.Drawing.Size(102, 31);
            this.LblTemes.TabIndex = 0;
            this.LblTemes.Text = "Temes";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmDadesUsuari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 894);
            this.Controls.Add(this.PnDadesUsuari);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label LblDadesUsuari;
        private PlaceholderTextBox.PlaceholderTextBox TxtUserName;
        private PlaceholderTextBox.PlaceholderTextBox TxtEmail;
        private PlaceholderTextBox.PlaceholderTextBox TxtDireccio;
        private PlaceholderTextBox.PlaceholderTextBox TxtCognom;
        private PlaceholderTextBox.PlaceholderTextBox TxtNom;
        private PlaceholderTextBox.PlaceholderTextBox TxtRepetirContrassenya;
        private PlaceholderTextBox.PlaceholderTextBox TxtContrasenya;
        private System.Windows.Forms.Button BtnConfirmarDades;
        private PlaceholderTextBox.PlaceholderTextBox TxtTags;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label LblTags;
        private PlaceholderTextBox.PlaceholderTextBox TxtListTags;
        private System.Windows.Forms.Button BtnAfegirTag;
    }
}

