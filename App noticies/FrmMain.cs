﻿using System;
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

		public FrmMain()
		{
			InitializeComponent();
		}

		private void FrmMain_Load(object sender, EventArgs e)
		{
			PbLogo.Left = this.Width / 2;
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
				frm.Show();
				this.Hide();
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
			PbMenu.BackColor = Color.FromArgb(255, 166, 62);
		}

		private void PbMenu_MouseLeave(object sender, EventArgs e)
		{
            PbMenu.BackColor = Color.FromArgb(255, 154, 62);
        }

		private void BtnBotiga_Click(object sender, EventArgs e)
		{
			FrmBotiga frm = new FrmBotiga();
			frm.Show();
			this.Hide();
		}

		private void label2_Click(object sender, EventArgs e)
		{
			FrmNoticia frm = new FrmNoticia();
			frm.Show();
			this.Hide();
		}
	}
}
