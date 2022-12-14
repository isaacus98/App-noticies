using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace App_noticies
{
	public partial class FrmDadesUsuari : Form
	{
        private static bool IsThemeDark=false;
        public static bool Targeta = false;
       
        public FrmDadesUsuari()
		{
            InitializeComponent();
            RbtnClar.Checked = !IsThemeDark;
            RbtnFosc.Checked = IsThemeDark;
            timer1.Start();
            TxtListTags.Text = FrmMain.tags;

            if (Targeta)
            {
                LblCaducitat.Text = "Data caducitat: " + FrmMain.Tar.GetData;
                LblNomResponsable.Text = "Responsable: " + FrmMain.Tar.GetNom;
                LblNumeroTargeta.Text = "Numero de targeta: " + FrmMain.Tar.GetNumero;
                LblCvv.Text = "Numero CVV: " + FrmMain.Tar.GetCvv;
            }
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
                this.BackColor = Color.FromArgb(66,66,66);
                this.RbtnClar.ForeColor = Color.White;
                this.RbtnFosc.ForeColor = Color.White;
                this.LblTemes.ForeColor = Color.White;
                this.PnlLinia.BackColor = Color.White;

                this.LblCaducitat.ForeColor = Color.White;
                this.LblNomResponsable.ForeColor = Color.White;
                this.LblNumeroTargeta.ForeColor = Color.White;
                this.LblTags.ForeColor = Color.White;
                this.LblDadesUsuari.ForeColor = Color.White;
                this.flowLayoutPanel2.BackColor = Color.White;
                this.flowLayoutPanel1.BackColor = Color.White;
                this.label1.ForeColor = Color.White;
                this.flowLayoutPanel3.BackColor = Color.White;
                this.LblCvv.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                this.RbtnClar.ForeColor = Color.Black;
                this.RbtnFosc.ForeColor = Color.Black;
                this.LblTemes.ForeColor = Color.Black;
                this.PnlLinia.BackColor = Color.Black;

                this.LblCaducitat.ForeColor = Color.Black;
                this.LblNomResponsable.ForeColor = Color.Black;
                this.LblNumeroTargeta.ForeColor = Color.Black;
                this.LblTags.ForeColor = Color.Black;
                this.LblDadesUsuari.ForeColor = Color.Black;
                this.flowLayoutPanel2.BackColor = Color.Black;
                this.flowLayoutPanel1.BackColor = Color.Black;
                this.label1.ForeColor = Color.Black;
                this.flowLayoutPanel3.BackColor = Color.Black;
                this.LblCvv.ForeColor = Color.Black;
            }
        }

        private void BtnConfirmarDades_Click(object sender, EventArgs e)
        {
            FrmMain.Username = TxtUserName.Text;

            FrmMain.LbIniciSessio.Text = FrmMain.Username;

            TxtCognom.Text = "";
            TxtContrasenya.Text = "";
            TxtDireccio.Text = "";
            TxtEmail.Text = "";
            TxtNom.Text = "";
            TxtRepetirContrassenya.Text = "";
            TxtUserName.Text = "";
        }

        private void BtnAfegirTag_Click(object sender, EventArgs e)
        {
            FrmMain.tags += "#" + TxtTags.Text + " ";

            TxtListTags.Text = FrmMain.tags;
        }

        private void BtnTargeta_Click(object sender, EventArgs e)
        {
            FrmMain.Tar = new Targeta();

            if (Targeta)
            {
                FrmMain.Tar.ShowDialog();
            }

            else
            {

                FrmMain.Tar.ShowDialog();
                BtnTargeta.Text = "Configurar";
            }

            LblCaducitat.Text = "Data caducitat: " + FrmMain.Tar.GetData;
            LblNomResponsable.Text = "Responsable: " + FrmMain.Tar.GetNom;
            LblNumeroTargeta.Text = "Numero de targeta: " + FrmMain.Tar.GetNumero;
            LblCvv.Text = "Numero CVV: " + FrmMain.Tar.GetCvv;
        }
    }
}
