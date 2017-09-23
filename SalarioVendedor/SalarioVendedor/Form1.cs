using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SalarioVendedor
{
    public partial class frmSalarioVendedor : Form
    {
        public frmSalarioVendedor()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double sal = Double.Parse(txbSalarioBruto.Text);
            if (rdbVendedor.Checked==true)
            {
                sal += Double.Parse(txbValorVendas.Text) / 10;
            }
            txbSalarioReceber.Text = "" + sal;

        }
    }
}
