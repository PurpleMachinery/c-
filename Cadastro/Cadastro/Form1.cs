using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int porc=0;
            if (System.Convert.ToInt32(txbIdade.Text) <= 18)
            {
                porc = 10;
            }
            else if (System.Convert.ToInt32(txbIdade.Text) > 18 && System.Convert.ToInt32(txbIdade.Text) <= 25)
            {
                porc = 12;
            }
            else if (System.Convert.ToInt32(txbIdade.Text) > 26)
            {
                porc = 15;
            }
            MessageBox.Show(txbNome.Text + " " + txbSobrenome.Text + "\nAumento: "+ porc + "%" + "\nSálario Atual: " + txbSálario.Text + "\nSálario Atualizado: " + (System.Convert.ToDouble(txbSálario.Text)+((System.Convert.ToDouble(txbSálario.Text) / 100) * porc)));
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbIdade.Text = "";
            txbNome.Text = "";
            txbSálario.Text = "";
            txbSobrenome.Text = "";
        }
    }
}
