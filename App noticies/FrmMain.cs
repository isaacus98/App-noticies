using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_noticies
{
	public partial class FrmMain : Form
    {
        private bool MenuDisplay = false;
		public static bool IniciatSessio = false;
		public static string Username = "";
        private static bool IsThemeDark = false;
        public static string tags = "";
		public FrmMain()
		{
			InitializeComponent();
            TimerTema.Start();
        }
		private void FrmMain_Load(object sender, EventArgs e)
		{
			PbLogo.Left = this.Width / 2;
			FrmNoticies frm = new FrmNoticies(PnFormularis);
			CarregarForm(frm,PnFormularis);
        }

        private void LbIniciSessio_MouseHover(object sender, EventArgs e)
		{
			LbIniciSessio.ForeColor = Color.Black;
		}

		private void LbIniciSessio_MouseLeave(object sender, EventArgs e)
		{
			LbIniciSessio.ForeColor = Color.White;
		}

		private void PbMenu_Click(object sender, EventArgs e)
		{
			Timer.Start();
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			if (!MenuDisplay)
			{
                if (PnMenuLateral.Width == 0)
                {
                    Timer.Stop();
                    MenuDisplay = true;
                }
                else
                {
                    PnMenuLateral.Width -= 10;
                }
                
			}
			else
			{
                if (PnMenuLateral.Width == 170)
                {
                    PnMenuLateral.Width = 170;
                    Timer.Stop();
                    MenuDisplay = false;
                }
                else
                {
                    PnMenuLateral.Width += 10;
                }
            }
		}

        private void LbIniciSessio_Click(object sender, EventArgs e)
        {

            if (IniciatSessio)
			{
				FrmDadesUsuari frm = new FrmDadesUsuari();
				CarregarForm(frm, PnFormularis);
			}
			else
			{
				Login log = new Login();
				log.ShowDialog();
                
                if (IniciatSessio)
				{
					LbIniciSessio.Text = Username;
				}
			}


        }

		private void PbMenu_MouseHover(object sender, EventArgs e)
		{
            if (!IsThemeDark)
            {

                PbMenu.BackColor = Color.FromArgb(229, 138, 55);
                
            }
            else
            {
                PbMenu.BackColor = Color.FromArgb(27,27,27);
            }
        }

		private void PbMenu_MouseLeave(object sender, EventArgs e)
		{
            if (!IsThemeDark)
            {

                PbMenu.BackColor = Color.FromArgb(255, 154, 62);

            }
            else
            {
                PbMenu.BackColor = Color.FromArgb(109, 109, 109);
            }
        }

		private void BtnBotiga_Click(object sender, EventArgs e)
		{
			FrmBotiga frm = new FrmBotiga();
			CarregarForm(frm, PnFormularis);
		}

        public static void CarregarForm(Form frm, Panel panel)
        {
            List<Form> llistaFormularis = panel.Controls.OfType<Form>().ToList<Form>();
            foreach (Form formulari in llistaFormularis)
            {
                formulari.Close();
            }

            panel.Controls.Clear();
            frm.TopLevel = false;
            frm.TopLevel = false;
            panel.Controls.Add(frm);
            frm.Show();
        }

		private void PbLogo_Click(object sender, EventArgs e)
		{
			FrmNoticies frm = new FrmNoticies(PnFormularis);
			CarregarForm(frm, PnFormularis);
		}
        public static bool GetIsThemeDark()
        {
            return FrmMain.IsThemeDark;
        }
        public static void SetIsThemeDark(bool NewIsThemeDark)
        {
            FrmMain.IsThemeDark= NewIsThemeDark;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (IsThemeDark)
            {
                BackColor = Color.FromArgb(66, 66, 66);
                PnMenuLateral.BackColor = Color.FromArgb(109, 109, 109);
                PnMenuSuperior.BackColor = Color.FromArgb(109, 109, 109);
                PbMenu.BackColor = Color.FromArgb(109, 109, 109);
                BtnBotiga.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 27, 27);
                BtnEconomia.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 27, 27);
                BtnCine.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 27, 27);
                BtnPolitica.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 27, 27);
                BtnEsports.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 27, 27);
               
            }
            else
            {
                BackColor = Color.White;
                PnMenuLateral.BackColor = Color.FromArgb(255, 154, 62);
                PnMenuSuperior.BackColor = Color.FromArgb(255, 154, 62);
                PbMenu.BackColor = Color.FromArgb(255, 154, 62);
                BtnBotiga.FlatAppearance.MouseOverBackColor = Color.FromArgb(229, 138, 55);
                BtnEconomia.FlatAppearance.MouseOverBackColor = Color.FromArgb(229, 138, 55);
                BtnCine.FlatAppearance.MouseOverBackColor = Color.FromArgb(229, 138, 55);
                BtnPolitica.FlatAppearance.MouseOverBackColor = Color.FromArgb(229, 138, 55);
                BtnEsports.FlatAppearance.MouseOverBackColor = Color.FromArgb(229, 138, 55);

            }
        }
    }
}
