using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculadoraBasica
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            double resultado;
            resultado = System.Convert.ToDouble(txbValor1.Text) + System.Convert.ToDouble(txbValor2.Text);
            lblResultado.Text = ""+resultado;
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            double resultado;
            resultado = System.Convert.ToDouble(txbValor1.Text) - System.Convert.ToDouble(txbValor2.Text);
            lblResultado.Text = "" + resultado;
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            double resultado;
            resultado = System.Convert.ToDouble(txbValor1.Text) * System.Convert.ToDouble(txbValor2.Text);
            lblResultado.Text = "" + resultado;
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double resultado;
            resultado = System.Convert.ToDouble(txbValor1.Text) / System.Convert.ToDouble(txbValor2.Text);
            lblResultado.Text = "" + resultado;
        }

        private void txbValor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txbValor2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
