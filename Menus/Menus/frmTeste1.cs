using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Menus
{
    public partial class frmTeste1 : Form
    {
        public frmTeste1()
        {
            InitializeComponent();
        }

        double amendoins = 0;
        double valor = 1, mult=1, preco=50;
        private void btnGA_Click(object sender, EventArgs e)
        {
            amendoins += valor;
            lblAmendoins.Text = "Amendoins: " + amendoins;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (amendoins >= preco)
            {
                amendoins -= preco;
                mult += 1;
                valor = mult;
                preco *= mult;
            }
            lblAmendoins.Text = "Amendoins: " + amendoins;
            lblX.Text = "Valor: " + mult;
            lblCusto.Text = "Custo: " + preco;
        }
    }
}
