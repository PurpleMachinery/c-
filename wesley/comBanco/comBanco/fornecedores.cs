using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace comBanco
{
    public partial class fornecedores : Form
    {
        public fornecedores()
        {
            InitializeComponent();
        }

        private void fornecedoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fornecedoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.empresasDataSet);

        }

        private void fornecedores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'empresasDataSet.Fornecedores' table. You can move, or remove it, as needed.
            this.fornecedoresTableAdapter.Fill(this.empresasDataSet.Fornecedores);

        }
    }
}
