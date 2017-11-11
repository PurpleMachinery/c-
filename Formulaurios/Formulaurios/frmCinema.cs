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
    public partial class frmCinema : Form
    {
        public frmCinema()
        {
            InitializeComponent();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Double total=0;
            String filme = cbFilme.Text;
            String[] filme2 = filme.Split('-');
            txbFilme.Text = filme2[0];
            if (ckbPipoca.Checked&&txbQtdPipoca.Text!="")
            {
                total += Double.Parse(txbQtdPipoca.Text) * 4.5;
            }
            if (ckbCoca.Checked&&txbQtdCoca.Text != "")
            {
                total += Double.Parse(txbQtdCoca.Text) * 4.25;
            }
            txbValorPedido.Text = "R$ " + total;
            if (rdbNormal.Checked)
            {
                total += 17;
                if(!ckb3d.Checked)txbValorIngresso.Text = "R$ 17,00";
                else txbValorIngresso.Text = "R$ 24,50";
            }
            else if (rdbEstudante.Checked)
            {
                total += 8.50;
                if (!ckb3d.Checked) txbValorIngresso.Text = "R$ 8,50";
                else txbValorIngresso.Text = "R$ 16,00";
            }
            else
            {
                MessageBox.Show("Selecione o Tipo de Ingresso");
            }
            txbTotal.Text = "R$ " + total;
        }
    }
}
