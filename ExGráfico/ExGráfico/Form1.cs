using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExGráfico
{
    public partial class frmPriProg : Form
    {
        public frmPriProg()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá mundo!");
        }
    }
}
