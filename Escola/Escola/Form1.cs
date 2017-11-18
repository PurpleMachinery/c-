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
    public partial class frmEscola : Form
    {
        public frmEscola()
        {
            InitializeComponent();
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlunos a = new frmAlunos();
            a.MdiParent = this;
            a.Show();
        }

        private void disciplinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDiciplina a = new frmDiciplina();
            a.MdiParent = this;
            a.Show();
        }

        private void mençãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMencoes a = new frmMencoes();
            a.MdiParent = this;
            a.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmAlunos a = new frmAlunos();
            a.MdiParent = this;
            a.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmDiciplina a = new frmDiciplina();
            a.MdiParent = this;
            a.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmMencoes a = new frmMencoes();
            a.MdiParent = this;
            a.Show();
        }
    }
}
