using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pronto
{
    public partial class frmFunc : Form
    {
        public frmFunc()
        {
            InitializeComponent();
        }

        private void funcionariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.funcionariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.funcDataSet);

        }

        private void frmFunc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'funcDataSet.funcionarios' table. You can move, or remove it, as needed.
            this.funcionariosTableAdapter.Fill(this.funcDataSet.funcionarios);

        }

        private void btnSalarioBruto_Click(object sender, EventArgs e)
        {
            double a = Double.Parse(salarioLiquidoTextBox.Text);
            double b = a - ((a / 100) * 26);
            b += 450;
            txbSalarioBruto.Text = "" + b;
        }
    }
}
