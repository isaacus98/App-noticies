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
    public partial class Targeta : Form
    {
        private static string DataCaducitat = "";
        private static string Responsable = "";
        private static string Numero = "";
        private static string CVV = "";

        private bool CaducitatCorrecte;
        private bool NumeroCorrecte;

        public Targeta()
        {
            InitializeComponent();
        }

        private void BtnConfirmarTargeta_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtResponsable.Text) || String.IsNullOrEmpty(TxtNumeroTargeta.Text) || String.IsNullOrEmpty(TxtCaducitat.Text))
                MessageBox.Show("Falten dades", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                if (TxtNumeroTargeta.Text.Length != 16)
                    MessageBox.Show("Dades incorrectes, exemple: 400001234567899", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    NumeroCorrecte = true;

                    if (TxtCaducitat.Text.Length != 4)
                        MessageBox.Show("Dades incorrectes, exemple: 1220", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        CaducitatCorrecte = true;

                }

            }

            if (CaducitatCorrecte && NumeroCorrecte)
            {
                FrmDadesUsuari.Targeta = true;

                DataCaducitat = TxtCaducitat.Text;
                Responsable = TxtResponsable.Text;
                Numero = TxtNumeroTargeta.Text;
                CVV = TxtCvv.Text;



                CaducitatCorrecte = false;
                NumeroCorrecte = false;

                this.Close();
            }
        }

        public String getData()
        {
            return DataCaducitat;
        }

        public String getCvv()
        {
            return CVV;
        }

        public String getNumero()
        {
            return Numero;
        }

        public String getNom()
        {
            return Responsable;
        }
    }
}
