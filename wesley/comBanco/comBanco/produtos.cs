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
    public partial class produtos : Form
    {
        public produtos()
        {
            InitializeComponent();
        }

        private void produtosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.empresasDataSet);

        }

        private void produtos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'empresasDataSet.Produtos' table. You can move, or remove it, as needed.
            this.produtosTableAdapter.Fill(this.empresasDataSet.Produtos);

        }
    }
}
