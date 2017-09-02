using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MaiorDeTres
{
    public partial class frmMaiorValorDeTres : Form
    {
        public frmMaiorValorDeTres()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (System.Convert.ToDouble(txbValorA.Text) > System.Convert.ToDouble(txbValorB.Text))
            {
                if (System.Convert.ToDouble(txbValorA.Text) > System.Convert.ToDouble(txbValorC.Text))
                {
                    lblResposta.Text = "O maior valor é A";
                }
                else
                {
                    lblResposta.Text = "O maior valor é C";
                }
            }
            else if (System.Convert.ToDouble(txbValorB.Text) > System.Convert.ToDouble(txbValorC.Text))
            {
                lblResposta.Text = "O maior valor é B";
            }
            else
            {
                lblResposta.Text = "O maior valor é C";
            }
        }
    }
}
