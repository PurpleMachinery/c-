using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculoDaMedia
{
    public partial class frmMedia : Form
    {
        public frmMedia()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double media = ((System.Convert.ToDouble(txb1Bim.Text) + System.Convert.ToDouble(txb2Bim.Text) + System.Convert.ToDouble(txb3Bim.Text) + System.Convert.ToDouble(txb4Bim.Text)) / 4);
            lblNome.Text = txbNome.Text;
            lblMedia.Text = "" + media;
            if (media >= 7)
            {
                lblEstado.Text = "Aprovado!";
            }
            else
            {
                lblEstado.Text = "Reprovado!";
            }
        }
    }
}
