using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace semBanco
{
    public partial class frmCalcularFrete : Form
    {
        public frmCalcularFrete()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valorCompra = 0, frete = 0;
            if (txbNome.Text == "")
            {
                MessageBox.Show("Insira o Nome");
                return;
            }
            if( txbValor.Text=="")
            {
                MessageBox.Show("Insira Valor");
                return;
            }
            if( cbLocal.Text=="")
            {
                MessageBox.Show("Insira Localização");
                return;
            }
            valorCompra = Double.Parse(txbValor.Text);
            if (cbLocal.Text == "Sul")
            {
                if (valorCompra > 500)
                {
                    frete = 58.30;
                }
                else if (valorCompra < 500)
                {
                    frete = 25.30;
                }
            }
            else if (cbLocal.Text == "Sudeste")
            {
                if (valorCompra > 500)
                {
                    frete = 48.38;
                }
                else if (valorCompra < 500)
                {
                    frete = 22.30;
                }
            }
            else if (cbLocal.Text == "Nordeste") 
            {
                if (valorCompra > 1500)
                {
                    frete = 100.3;
                }
                else if (valorCompra < 1500)
                {
                    frete = 59.3;
                }
            }
            else if (cbLocal.Text == "Norte")
            {
                if (valorCompra > 800)
                {
                    frete = 120.25;
                }
                else if (valorCompra < 800)
                {
                    frete = 70.85;
                }
            }
            else if (cbLocal.Text == "Centro-Oeste")
            {
                if (valorCompra > 900)
                {
                    frete = 90;
                }
                else if (valorCompra < 900)
                {
                    frete = 48.40;
                }
            }
            lblValorF.Text = "" + valorCompra + " R$";
            lblFreteF.Text = "" + frete + " R$";
            lblTotalF.Text = "" + (valorCompra + frete) + " R$";
        }
    }
}
