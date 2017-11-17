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
    public partial class frmDiciplina : Form
    {
        public frmDiciplina()
        {
            InitializeComponent();
        }

        private void disciplinasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.disciplinasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd_EscolaDataSet);

        }

        private void frmDiciplina_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bd_EscolaDataSet.Disciplinas' table. You can move, or remove it, as needed.
            this.disciplinasTableAdapter.Fill(this.bd_EscolaDataSet.Disciplinas);

        }
    }
}
