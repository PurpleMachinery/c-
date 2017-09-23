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
    public partial class frmFazendoPedidos : Form
    {
        public frmFazendoPedidos()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double total=0;
            if (ckbChoop.Checked == true)
            {
                total += 4.50 * Double.Parse(txbQChoop.Text);
            }
            if (ckbPetiscos.Checked == true)
            {
                total += 7.90 * Double.Parse(txbQPetisco.Text);
            }
            if (ckbRefeicao.Checked == true)
            {
                total += 15.90 * Double.Parse(txbQRefeicao.Text);
            }



            txbTotalParcial.Text = "" + total;
            txbTaxaServico.Text = ""+ (total / 100) * 8;
            total += (total / 100) * 8;
            txbTotal.Text = "" + total;
        }
    }
}
