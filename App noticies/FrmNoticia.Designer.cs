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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNoticia));
            this.PnMenuSuperior = new System.Windows.Forms.Panel();
            this.TxtBuscar = new PlaceholderTextBox.PlaceholderTextBox();
            this.LbIniciSessio = new System.Windows.Forms.Label();
            this.PnMenuLateral = new System.Windows.Forms.Panel();
            this.PnNoticies = new System.Windows.Forms.Panel();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBotiga = new FontAwesome.Sharp.IconButton();
            this.BtnCine = new FontAwesome.Sharp.IconButton();
            this.BtnEconomia = new FontAwesome.Sharp.IconButton();
            this.BtnPolitica = new FontAwesome.Sharp.IconButton();
            this.BtnEsports = new FontAwesome.Sharp.IconButton();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.PbMenu = new System.Windows.Forms.PictureBox();
            this.PnMenuSuperior.SuspendLayout();
            this.PnMenuLateral.SuspendLayout();
            this.PnNoticies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // PnMenuSuperior
            // 
            this.PnMenuSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(154)))), ((int)(((byte)(62)))));
            this.PnMenuSuperior.Controls.Add(this.TxtBuscar);
            this.PnMenuSuperior.Controls.Add(this.LbIniciSessio);
            this.PnMenuSuperior.Controls.Add(this.BtnBuscar);
            this.PnMenuSuperior.Controls.Add(this.PbLogo);
            this.PnMenuSuperior.Controls.Add(this.PbMenu);
            this.PnMenuSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnMenuSuperior.Location = new System.Drawing.Point(0, 0);
            this.PnMenuSuperior.Margin = new System.Windows.Forms.Padding(2);
            this.PnMenuSuperior.Name = "PnMenuSuperior";
            this.PnMenuSuperior.Size = new System.Drawing.Size(1904, 65);
            this.PnMenuSuperior.TabIndex = 0;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.Location = new System.Drawing.Point(76, 20);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.PlaceholderText = "Buscar";
            this.TxtBuscar.Size = new System.Drawing.Size(206, 29);
            this.TxtBuscar.TabIndex = 4;
            // 
            // LbIniciSessio
            // 
            this.LbIniciSessio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LbIniciSessio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbIniciSessio.ForeColor = System.Drawing.Color.White;
            this.LbIniciSessio.Location = new System.Drawing.Point(1721, 9);
            this.LbIniciSessio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbIniciSessio.Name = "LbIniciSessio";
            this.LbIniciSessio.Size = new System.Drawing.Size(172, 51);
            this.LbIniciSessio.TabIndex = 3;
            this.LbIniciSessio.Text = "Iniciar Sessió/Registrar";
            this.LbIniciSessio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbIniciSessio.Click += new System.EventHandler(this.LbIniciSessio_Click);
            this.LbIniciSessio.MouseLeave += new System.EventHandler(this.LbIniciSessio_MouseLeave);
            this.LbIniciSessio.MouseHover += new System.EventHandler(this.LbIniciSessio_MouseHover);
            // 
            // PnMenuLateral
            // 
            this.PnMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(154)))), ((int)(((byte)(62)))));
            this.PnMenuLateral.Controls.Add(this.BtnBotiga);
            this.PnMenuLateral.Controls.Add(this.BtnCine);
            this.PnMenuLateral.Controls.Add(this.BtnEconomia);
            this.PnMenuLateral.Controls.Add(this.BtnPolitica);
            this.PnMenuLateral.Controls.Add(this.BtnEsports);
            this.PnMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnMenuLateral.Location = new System.Drawing.Point(0, 65);
            this.PnMenuLateral.Margin = new System.Windows.Forms.Padding(2);
            this.PnMenuLateral.Name = "PnMenuLateral";
            this.PnMenuLateral.Size = new System.Drawing.Size(169, 976);
            this.PnMenuLateral.TabIndex = 1;
            // 
            // PnNoticies
            // 
            this.PnNoticies.BackColor = System.Drawing.Color.White;
            this.PnNoticies.Controls.Add(this.label1);
            this.PnNoticies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnNoticies.Location = new System.Drawing.Point(169, 65);
            this.PnNoticies.Margin = new System.Windows.Forms.Padding(2);
            this.PnNoticies.Name = "PnNoticies";
            this.PnNoticies.Size = new System.Drawing.Size(1735, 976);
            this.PnNoticies.TabIndex = 2;
            // 
            // Timer
            // 
            this.Timer.Interval = 50;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
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
            // BtnBotiga
            // 
            this.BtnBotiga.BackColor = System.Drawing.Color.Transparent;
            this.BtnBotiga.FlatAppearance.BorderSize = 0;
            this.BtnBotiga.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(62)))));
            this.BtnBotiga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(62)))));
            this.BtnBotiga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBotiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBotiga.ForeColor = System.Drawing.Color.White;
            this.BtnBotiga.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.BtnBotiga.IconColor = System.Drawing.Color.White;
            this.BtnBotiga.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBotiga.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBotiga.Location = new System.Drawing.Point(-1, 245);
            this.BtnBotiga.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBotiga.Name = "BtnBotiga";
            this.BtnBotiga.Size = new System.Drawing.Size(170, 54);
            this.BtnBotiga.TabIndex = 4;
            this.BtnBotiga.Text = "Botiga";
            this.BtnBotiga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBotiga.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBotiga.UseVisualStyleBackColor = false;
            this.BtnBotiga.Click += new System.EventHandler(this.BtnBotiga_Click);
            // 
            // BtnCine
            // 
            this.BtnCine.BackColor = System.Drawing.Color.Transparent;
            this.BtnCine.FlatAppearance.BorderSize = 0;
            this.BtnCine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(62)))));
            this.BtnCine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(62)))));
            this.BtnCine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCine.ForeColor = System.Drawing.Color.White;
            this.BtnCine.IconChar = FontAwesome.Sharp.IconChar.Film;
            this.BtnCine.IconColor = System.Drawing.Color.White;
            this.BtnCine.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCine.Location = new System.Drawing.Point(0, 194);
            this.BtnCine.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCine.Name = "BtnCine";
            this.BtnCine.Size = new System.Drawing.Size(170, 54);
            this.BtnCine.TabIndex = 3;
            this.BtnCine.Text = "Cine";
            this.BtnCine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCine.UseVisualStyleBackColor = false;
            // 
            // BtnEconomia
            // 
            this.BtnEconomia.BackColor = System.Drawing.Color.Transparent;
            this.BtnEconomia.FlatAppearance.BorderSize = 0;
            this.BtnEconomia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(62)))));
            this.BtnEconomia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(62)))));
            this.BtnEconomia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEconomia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEconomia.ForeColor = System.Drawing.Color.White;
            this.BtnEconomia.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.BtnEconomia.IconColor = System.Drawing.Color.White;
            this.BtnEconomia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEconomia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEconomia.Location = new System.Drawing.Point(0, 141);
            this.BtnEconomia.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEconomia.Name = "BtnEconomia";
            this.BtnEconomia.Size = new System.Drawing.Size(170, 54);
            this.BtnEconomia.TabIndex = 2;
            this.BtnEconomia.Text = "Economia";
            this.BtnEconomia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEconomia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEconomia.UseVisualStyleBackColor = false;
            // 
            // BtnPolitica
            // 
            this.BtnPolitica.BackColor = System.Drawing.Color.Transparent;
            this.BtnPolitica.FlatAppearance.BorderSize = 0;
            this.BtnPolitica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(62)))));
            this.BtnPolitica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(62)))));
            this.BtnPolitica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPolitica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPolitica.ForeColor = System.Drawing.Color.White;
            this.BtnPolitica.IconChar = FontAwesome.Sharp.IconChar.Landmark;
            this.BtnPolitica.IconColor = System.Drawing.Color.White;
            this.BtnPolitica.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPolitica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPolitica.Location = new System.Drawing.Point(0, 89);
            this.BtnPolitica.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPolitica.Name = "BtnPolitica";
            this.BtnPolitica.Size = new System.Drawing.Size(170, 54);
            this.BtnPolitica.TabIndex = 1;
            this.BtnPolitica.Text = "Politica";
            this.BtnPolitica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPolitica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPolitica.UseVisualStyleBackColor = false;
            // 
            // BtnEsports
            // 
            this.BtnEsports.BackColor = System.Drawing.Color.Transparent;
            this.BtnEsports.FlatAppearance.BorderSize = 0;
            this.BtnEsports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(62)))));
            this.BtnEsports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(166)))), ((int)(((byte)(62)))));
            this.BtnEsports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEsports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEsports.ForeColor = System.Drawing.Color.White;
            this.BtnEsports.IconChar = FontAwesome.Sharp.IconChar.SoccerBall;
            this.BtnEsports.IconColor = System.Drawing.Color.White;
            this.BtnEsports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEsports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEsports.Location = new System.Drawing.Point(0, 36);
            this.BtnEsports.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEsports.Name = "BtnEsports";
            this.BtnEsports.Size = new System.Drawing.Size(170, 54);
            this.BtnEsports.TabIndex = 0;
            this.BtnEsports.Text = "Esports";
            this.BtnEsports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEsports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEsports.UseVisualStyleBackColor = false;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.SystemColors.Window;
            this.BtnBuscar.BackgroundImage = global::App_noticies.Properties.Resources.lupa;
            this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Location = new System.Drawing.Point(281, 20);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(29, 29);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // PbLogo
            // 
            this.PbLogo.Image = global::App_noticies.Properties.Resources.Logo;
            this.PbLogo.Location = new System.Drawing.Point(466, 0);
            this.PbLogo.Margin = new System.Windows.Forms.Padding(2);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(88, 65);
            this.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbLogo.TabIndex = 1;
            this.PbLogo.TabStop = false;
            // 
            // PbMenu
            // 
            this.PbMenu.Image = ((System.Drawing.Image)(resources.GetObject("PbMenu.Image")));
            this.PbMenu.Location = new System.Drawing.Point(9, 10);
            this.PbMenu.Margin = new System.Windows.Forms.Padding(2);
            this.PbMenu.Name = "PbMenu";
            this.PbMenu.Size = new System.Drawing.Size(52, 50);
            this.PbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbMenu.TabIndex = 0;
            this.PbMenu.TabStop = false;
            this.PbMenu.Click += new System.EventHandler(this.PbMenu_Click);
            this.PbMenu.MouseLeave += new System.EventHandler(this.PbMenu_MouseLeave);
            this.PbMenu.MouseHover += new System.EventHandler(this.PbMenu_MouseHover);
            // 
            // FrmNoticia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.PnNoticies);
            this.Controls.Add(this.PnMenuLateral);
            this.Controls.Add(this.PnMenuSuperior);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmNoticia";
            this.Text = "App noticies";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.PnMenuSuperior.ResumeLayout(false);
            this.PnMenuSuperior.PerformLayout();
            this.PnMenuLateral.ResumeLayout(false);
            this.PnNoticies.ResumeLayout(false);
            this.PnNoticies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnMenuSuperior;
        private System.Windows.Forms.Panel PnMenuLateral;
        private System.Windows.Forms.Panel PnNoticies;
        private System.Windows.Forms.PictureBox PbMenu;
        private System.Windows.Forms.PictureBox PbLogo;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label LbIniciSessio;
        private FontAwesome.Sharp.IconButton BtnCine;
        private FontAwesome.Sharp.IconButton BtnEconomia;
        private FontAwesome.Sharp.IconButton BtnPolitica;
        private FontAwesome.Sharp.IconButton BtnEsports;
        private System.Windows.Forms.Timer Timer;
        private PlaceholderTextBox.PlaceholderTextBox TxtBuscar;
        private FontAwesome.Sharp.IconButton BtnBotiga;
        private System.Windows.Forms.Label label1;
    }
}

