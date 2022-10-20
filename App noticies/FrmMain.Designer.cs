namespace App_noticies
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.PnMenuSuperior = new System.Windows.Forms.Panel();
            this.LbIniciSessio = new System.Windows.Forms.Label();
            this.TxtBuscar = new Windows.Forms.HintTextBox(this.components);
            this.PnMenuLateral = new System.Windows.Forms.Panel();
            this.PnNoticies = new System.Windows.Forms.Panel();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.PbMenu = new System.Windows.Forms.PictureBox();
            this.BtnEsports = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.PnMenuSuperior.SuspendLayout();
            this.PnMenuLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // PnMenuSuperior
            // 
            this.PnMenuSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(154)))), ((int)(((byte)(62)))));
            this.PnMenuSuperior.Controls.Add(this.LbIniciSessio);
            this.PnMenuSuperior.Controls.Add(this.BtnBuscar);
            this.PnMenuSuperior.Controls.Add(this.PbLogo);
            this.PnMenuSuperior.Controls.Add(this.TxtBuscar);
            this.PnMenuSuperior.Controls.Add(this.PbMenu);
            this.PnMenuSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnMenuSuperior.Location = new System.Drawing.Point(0, 0);
            this.PnMenuSuperior.Name = "PnMenuSuperior";
            this.PnMenuSuperior.Size = new System.Drawing.Size(1361, 80);
            this.PnMenuSuperior.TabIndex = 0;
            // 
            // LbIniciSessio
            // 
            this.LbIniciSessio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LbIniciSessio.AutoSize = true;
            this.LbIniciSessio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbIniciSessio.ForeColor = System.Drawing.Color.White;
            this.LbIniciSessio.Location = new System.Drawing.Point(1055, 31);
            this.LbIniciSessio.Name = "LbIniciSessio";
            this.LbIniciSessio.Size = new System.Drawing.Size(211, 25);
            this.LbIniciSessio.TabIndex = 3;
            this.LbIniciSessio.Text = "Iniciar Sessió/Registrar";
            this.LbIniciSessio.MouseLeave += new System.EventHandler(this.LbIniciSessio_MouseLeave);
            this.LbIniciSessio.MouseHover += new System.EventHandler(this.LbIniciSessio_MouseHover);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.EnterToTab = false;
            this.TxtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.ForeColor = System.Drawing.Color.Gray;
            this.TxtBuscar.HintColor = System.Drawing.Color.Gray;
            this.TxtBuscar.HintValue = "Buscar";
            this.TxtBuscar.Location = new System.Drawing.Point(103, 25);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(273, 34);
            this.TxtBuscar.TabIndex = 0;
            this.TxtBuscar.TextForeColor = System.Drawing.Color.Black;
            this.TxtBuscar.Value = "";
            // 
            // PnMenuLateral
            // 
            this.PnMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(154)))), ((int)(((byte)(62)))));
            this.PnMenuLateral.Controls.Add(this.iconButton3);
            this.PnMenuLateral.Controls.Add(this.iconButton2);
            this.PnMenuLateral.Controls.Add(this.iconButton1);
            this.PnMenuLateral.Controls.Add(this.BtnEsports);
            this.PnMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnMenuLateral.Location = new System.Drawing.Point(0, 80);
            this.PnMenuLateral.Name = "PnMenuLateral";
            this.PnMenuLateral.Size = new System.Drawing.Size(225, 670);
            this.PnMenuLateral.TabIndex = 1;
            // 
            // PnNoticies
            // 
            this.PnNoticies.BackColor = System.Drawing.Color.White;
            this.PnNoticies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnNoticies.Location = new System.Drawing.Point(225, 80);
            this.PnNoticies.Name = "PnNoticies";
            this.PnNoticies.Size = new System.Drawing.Size(1136, 670);
            this.PnNoticies.TabIndex = 2;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.SystemColors.Window;
            this.BtnBuscar.BackgroundImage = global::App_noticies.Properties.Resources.lupa;
            this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Location = new System.Drawing.Point(375, 25);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(33, 34);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // PbLogo
            // 
            this.PbLogo.Image = global::App_noticies.Properties.Resources.Logo;
            this.PbLogo.Location = new System.Drawing.Point(621, 0);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(118, 80);
            this.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbLogo.TabIndex = 1;
            this.PbLogo.TabStop = false;
            // 
            // PbMenu
            // 
            this.PbMenu.Image = ((System.Drawing.Image)(resources.GetObject("PbMenu.Image")));
            this.PbMenu.Location = new System.Drawing.Point(12, 12);
            this.PbMenu.Name = "PbMenu";
            this.PbMenu.Size = new System.Drawing.Size(70, 62);
            this.PbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbMenu.TabIndex = 0;
            this.PbMenu.TabStop = false;
            this.PbMenu.Click += new System.EventHandler(this.PbMenu_Click);
            // 
            // BtnEsports
            // 
            this.BtnEsports.BackColor = System.Drawing.Color.Transparent;
            this.BtnEsports.FlatAppearance.BorderSize = 0;
            this.BtnEsports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEsports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEsports.ForeColor = System.Drawing.Color.White;
            this.BtnEsports.IconChar = FontAwesome.Sharp.IconChar.SoccerBall;
            this.BtnEsports.IconColor = System.Drawing.Color.White;
            this.BtnEsports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEsports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEsports.Location = new System.Drawing.Point(0, 44);
            this.BtnEsports.Name = "BtnEsports";
            this.BtnEsports.Size = new System.Drawing.Size(225, 66);
            this.BtnEsports.TabIndex = 0;
            this.BtnEsports.Text = "Esports";
            this.BtnEsports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEsports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEsports.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Landmark;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 109);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(225, 66);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "Politica";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Transparent;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 174);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(225, 66);
            this.iconButton2.TabIndex = 2;
            this.iconButton2.Text = "Economia";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.Transparent;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Film;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(0, 239);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(225, 66);
            this.iconButton3.TabIndex = 3;
            this.iconButton3.Text = "Cine";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // Timer
            // 
            this.Timer.Interval = 50;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 750);
            this.Controls.Add(this.PnNoticies);
            this.Controls.Add(this.PnMenuLateral);
            this.Controls.Add(this.PnMenuSuperior);
            this.Name = "FrmMain";
            this.Text = "App noticies";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.PnMenuSuperior.ResumeLayout(false);
            this.PnMenuSuperior.PerformLayout();
            this.PnMenuLateral.ResumeLayout(false);
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
        private Windows.Forms.HintTextBox TxtBuscar;
        private System.Windows.Forms.Label LbIniciSessio;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton BtnEsports;
        private System.Windows.Forms.Timer Timer;
    }
}

