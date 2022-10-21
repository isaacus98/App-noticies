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
		Panel Pn;
		public FrmNoticies()
		{
			InitializeComponent();
		}

		public FrmNoticies(Panel pn)
		{
			InitializeComponent();
			Pn = pn;
		}

		private void Noticia_Click(object sender, EventArgs e)
		{
			FrmNoticia frm = new FrmNoticia();
			FrmMain.CarregarForm(frm, Pn);
		}
	}
}
