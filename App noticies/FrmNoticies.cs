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
	public partial class FrmNoticies : Form
	{
        private static bool IsThemeDark = false;
		Panel Pn;
		public FrmNoticies()
		{
			InitializeComponent();
        }
        private void LoadTheme()
        {
            if (IsThemeDark)
            {
                PnNoticia.BackColor = Color.FromArgb(66, 66, 66);

                label1.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label2.ForeColor = Color.White;

                label3.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label12.ForeColor = Color.White;

                label11.ForeColor = Color.White;
                label9.ForeColor = Color.White;
                label8.ForeColor = Color.White;

                
                label7.ForeColor = Color.White;
                label10.ForeColor = Color.White;
                label4.ForeColor = Color.White;


            }
            else
            {
                PnNoticia.BackColor = Color.White;

                label1.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;

                label3.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label12.ForeColor = Color.Black;

                label11.ForeColor = Color.Black;
                label9.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;


                label7.ForeColor = Color.Black;
                label10.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
            }
        }

        public FrmNoticies(Panel pn)
		{
			InitializeComponent();
			Pn = pn;
            LoadTheme();
		}

		private void Noticia_Click(object sender, EventArgs e)
		{
			FrmNoticia frm = new FrmNoticia();
			FrmMain.CarregarForm(frm, Pn);
		}
        public static bool GetIsThemeDark()
        {
            return IsThemeDark;
        }
        public static void SetIsThemeDark(bool NewIsThemedark)
        {
            IsThemeDark = NewIsThemedark;
        }
    }
}
