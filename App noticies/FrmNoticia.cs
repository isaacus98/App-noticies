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
	public partial class FrmNoticia : Form
	{
        private static bool IsThemeDark = false;
		public FrmNoticia()
		{
			InitializeComponent();
            LoadTheme();
        }
        private void LoadTheme()
        {
            if (IsThemeDark)
            {
                BackColor = Color.FromArgb(66, 66, 66);
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
            }
            else
            {
                BackColor = Color.White;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
            }
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
