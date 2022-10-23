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
	public partial class FrmDadesUsuari : Form
	{
        private static bool IsThemeDark=false;
		public FrmDadesUsuari()
		{
			InitializeComponent();
            RbtnClar.Checked = !IsThemeDark;
            RbtnFosc.Checked = IsThemeDark;
            timer1.Start();
		}
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (RbtnClar.Checked)
            {
                IsThemeDark = false;
                FrmMain.SetIsThemeDark(false);
                FrmBotiga.SetIsThemeDark(false);
                FrmNoticia.SetIsThemeDark(false);
                FrmNoticies.SetIsThemeDark(false);

            }
            if (RbtnFosc.Checked)
            {
                IsThemeDark = true;
                FrmMain.SetIsThemeDark(true);
                FrmBotiga.SetIsThemeDark(true);
                FrmNoticia.SetIsThemeDark(true);
                FrmNoticies.SetIsThemeDark(true);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (IsThemeDark)
            {
                this.BackColor = Color.Black;
                this.RbtnClar.ForeColor = Color.White;
                this.RbtnFosc.ForeColor = Color.White;
                this.LblTemes.ForeColor = Color.White;
                this.PnlLinia.BackColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                this.RbtnClar.ForeColor = Color.Black;
                this.RbtnFosc.ForeColor = Color.Black;
                this.LblTemes.ForeColor = Color.Black;
                this.PnlLinia.BackColor = Color.Black;
            }
        }
    }
}
