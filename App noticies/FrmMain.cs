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

			Console.WriteLine(PnMenuLateral.Width);
		}

        private void LbIniciSessio_Click(object sender, EventArgs e)
        {

        }
    }
}
