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
    public partial class Login : Form
    {
        private bool register=false;
        public Login()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            BtnFacebook.Visible = false;
            BtnGoogle.Visible = false;
            BtnTwitter.Visible = false;
            TxtRepetirContrasenya.Visible = true;
            TxtEmail.Visible = true;
            TxtNom.Visible = true;
            BtnRegistrar.Visible = false;
            BtnIniciSessio.Text = "Continua";
            register = true;
        }

        private void BtnIniciSessio_Click(object sender, EventArgs e)
        {
            if (register)
            {
                if(String.IsNullOrEmpty(TxtNom.Text)&& String.IsNullOrEmpty(TxtContrasenya.Text)&&String.IsNullOrEmpty(TxtRepetirContrasenya.Text)&& String.IsNullOrEmpty(TxtUserName.Text)&& String.IsNullOrEmpty(TxtEmail.Text))
                {
                    MessageBox.Show("Algun camp està buit.");
                }
            }
            else
            {

            }
        }
    }
}
