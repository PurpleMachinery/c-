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
    public partial class frmComBanco : Form
    {
        public frmComBanco()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            statusData.Text = "Data :" + DateTime.Now.ToString("dd/MM/yyyy");
            statusHora.Text = "Hora: " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            statusHora.Text = "Hora: " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void tsiFonecedores_Click(object sender, EventArgs e)
        {
            fornecedores forn = new fornecedores();
            forn.MdiParent = this;
            forn.Show();
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            fornecedores forn = new fornecedores();
            forn.MdiParent = this;
            forn.Show();
        }

        private void tsiProdutos_Click(object sender, EventArgs e)
        {
            produtos forn = new produtos();
            forn.MdiParent = this;
            forn.Show();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            produtos forn = new produtos();
            forn.MdiParent = this;
            forn.Show();
        }

        private void tsiSobre_Click(object sender, EventArgs e)
        {
            sobre s = new sobre();
            s.MdiParent = this;
            s.Show();
        }

        private void tsiSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmComBanco_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo");
            else
            {
                MessageBox.Show("Ficando");
                e.Cancel = true;
            }
        }
    }
}
