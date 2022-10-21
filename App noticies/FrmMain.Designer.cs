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
            this.PnMenuLateral = new System.Windows.Forms.Panel();
            this.PnNoticies = new System.Windows.Forms.Panel();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.TxtBuscar = new PlaceholderTextBox.PlaceholderTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnBotiga = new FontAwesome.Sharp.IconButton();
            this.BtnCine = new FontAwesome.Sharp.IconButton();
            this.BtnEconomia = new FontAwesome.Sharp.IconButton();
            this.BtnPolitica = new FontAwesome.Sharp.IconButton();
            this.BtnEsports = new FontAwesome.Sharp.IconButton();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.PbMenu = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.PnMenuSuperior.SuspendLayout();
            this.PnMenuLateral.SuspendLayout();
            this.PnNoticies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
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
            this.PnNoticies.Controls.Add(this.label12);
            this.PnNoticies.Controls.Add(this.label9);
            this.PnNoticies.Controls.Add(this.label4);
            this.PnNoticies.Controls.Add(this.label1);
            this.PnNoticies.Controls.Add(this.pictureBox4);
            this.PnNoticies.Controls.Add(this.label3);
            this.PnNoticies.Controls.Add(this.label6);
            this.PnNoticies.Controls.Add(this.pictureBox3);
            this.PnNoticies.Controls.Add(this.label7);
            this.PnNoticies.Controls.Add(this.label10);
            this.PnNoticies.Controls.Add(this.label8);
            this.PnNoticies.Controls.Add(this.label11);
            this.PnNoticies.Controls.Add(this.pictureBox5);
            this.PnNoticies.Controls.Add(this.label5);
            this.PnNoticies.Controls.Add(this.label2);
            this.PnNoticies.Controls.Add(this.pictureBox2);
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
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.Location = new System.Drawing.Point(76, 20);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.PlaceholderText = "Buscar";
            this.TxtBuscar.Size = new System.Drawing.Size(206, 29);
            this.TxtBuscar.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(599, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lucian Freud, el retrato como autopsia";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(239, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(599, 89);
            this.label5.TabIndex = 7;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(235, 846);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(599, 74);
            this.label8.TabIndex = 16;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(234, 800);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(599, 23);
            this.label11.TabIndex = 13;
            this.label11.Text = "Elon Musk quiere despedir al 75% de la plantilla de Twitter";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::App_noticies.Properties.Resources.elonMusk;
            this.pictureBox5.Location = new System.Drawing.Point(238, 501);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(599, 296);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::App_noticies.Properties.Resources.pintura;
            this.pictureBox2.Location = new System.Drawing.Point(238, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(599, 296);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.label2_Click);
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
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(885, 846);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(607, 89);
            this.label3.TabIndex = 22;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(886, 800);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(606, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "Pedro Sanchez";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::App_noticies.Properties.Resources.pedro_sanchez;
            this.pictureBox3.Location = new System.Drawing.Point(890, 501);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(606, 296);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(890, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(607, 89);
            this.label7.TabIndex = 19;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(886, 348);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(607, 23);
            this.label10.TabIndex = 18;
            this.label10.Text = "Ocho minutos demoledores del Barça liquidan al Villarreal";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::App_noticies.Properties.Resources.lewandowski;
            this.pictureBox4.Location = new System.Drawing.Point(890, 49);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(607, 296);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Autor";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(892, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(600, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Autor";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(239, 823);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(600, 23);
            this.label9.TabIndex = 25;
            this.label9.Text = "Autor";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(892, 823);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(600, 23);
            this.label12.TabIndex = 26;
            this.label12.Text = "Autor";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.PnNoticies);
            this.Controls.Add(this.PnMenuLateral);
            this.Controls.Add(this.PnMenuSuperior);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "App noticies";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.PnMenuSuperior.ResumeLayout(false);
            this.PnMenuSuperior.PerformLayout();
            this.PnMenuLateral.ResumeLayout(false);
            this.PnNoticies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}

