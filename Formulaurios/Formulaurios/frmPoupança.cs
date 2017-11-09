using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmPoupança : Form
    {
        public frmPoupança()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double i = Double.Parse(txbTaxa.Text), p = Double.Parse(txbValor.Text), n = Double.Parse(txbMeses.Text);
            double k;
            k = p * (Math.Pow(1 + i, n) - 1) / i;
            txbResult.Text = ""+k;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbMeses.Text = "";
            txbResult.Text = "";
            txbTaxa.Text = "";
            txbValor.Text = "";
        }
    }
}
