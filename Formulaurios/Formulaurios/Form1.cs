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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void poupançaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPoupança p = new frmPoupança();
            p.MdiParent = this;
            p.Show();
        }

        private void pizzariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPizzaria p = new frmPizzaria();
            p.MdiParent = this;
            p.Show();
        }

        private void cinemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCinema p = new frmCinema();
            p.MdiParent = this;
            p.Show();
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustom p = new frmCustom();
            p.MdiParent = this;
            p.Show();
        }
    }
}
