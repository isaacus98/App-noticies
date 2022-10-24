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
	public partial class FrmBotiga : Form
	{
        private static bool IsThemeDark = false;
		public FrmBotiga()
		{
			InitializeComponent();
            LoadTheme();
		}
        private void LoadTheme()
        {
            if (IsThemeDark)
            {
                BackColor = Color.FromArgb(66, 66, 66); ;
            }
            else
            {
                BackColor = Color.White;
            }
        }
        public static bool GetIsThemeDark()
        {
            return IsThemeDark;
        }
        public static void SetIsThemeDark(bool NewIsThemedark)
        {
            IsThemeDark=NewIsThemedark;
        }
    }
}
