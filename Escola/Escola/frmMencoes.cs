using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Escola
{
    public partial class frmMencoes : Form
    {
        public frmMencoes()
        {
            InitializeComponent();
        }

        private void registro_MencoesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.registro_MencoesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd_EscolaDataSet);

        }

        private void frmMencoes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bd_EscolaDataSet.Registro_Mencoes' table. You can move, or remove it, as needed.
            this.registro_MencoesTableAdapter.Fill(this.bd_EscolaDataSet.Registro_Mencoes);

        }
    }
}
