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
    public partial class frmCustom : Form
    {
        public frmCustom()
        {
            InitializeComponent();
            for (int i = 2020; i > 1960; i--)
            {
                cbAno.Items.Add(i);
            }
        }

        private void btnVerificarTotal_Click(object sender, EventArgs e)
        {
            double total = 0;
            if (cbServicos.Text!="")
            {
                String toda = cbServicos.Text;
                String[] splitiada = toda.Split('$');
                String a = splitiada[1];
                total = Double.Parse(a);
            }
            if (ckbCarroceria.Checked) total += 599;
            if (ckbInterior.Checked) total += 850;
            if (ckbSuspencao.Checked) total += 450;
            if (ckbMotor.Checked) total += 799;

            txbValorTotal.Text = "" + total;
        }
    }
}
