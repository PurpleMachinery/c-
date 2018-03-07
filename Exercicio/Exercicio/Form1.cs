using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void funcionariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.funcionariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.funcDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'funcDataSet.funcionarios' table. You can move, or remove it, as needed.
            this.funcionariosTableAdapter.Fill(this.funcDataSet.funcionarios);

        }

        private void btnSB_Click(object sender, EventArgs e)
        {
            double salarioLiquido = Double.Parse(salarioLiquidoTextBox.Text);
            double salarioBruto = salarioLiquido - ((salarioLiquido / 100) * 26);
            salarioBruto += 450;
            txbSalarioBruto.Text = ""+salarioBruto;
        }
    }
}
