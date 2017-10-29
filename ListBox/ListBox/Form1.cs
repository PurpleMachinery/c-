using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListBox
{
    public partial class frmList : Form
    {
        public frmList()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double a = 0;
            double total = 0;
            double desc = Double.Parse(txbDesc.Text);
            if (Double.Parse(nudIdade.Text) == 0) MessageBox.Show("Idade Invalida");
            if (!mtxbCpf.MaskCompleted) MessageBox.Show("CPF inválido");
            if (txbNome.Text == null) MessageBox.Show("CPF inválido");
            if (txbEndereco.Text == null) MessageBox.Show("Endereco inválido");
            String stringTotal = "", stringPreco="";
            String[] stringSplit;
            for (int i = 0; i < lbLivros.Items.Count; i++)
            {                
                if (lbLivros.GetSelected(i) == true)
                {
                    a++;
                    stringTotal = lbLivros.Items[i].ToString();
                    stringSplit = stringTotal.Split('$');
                    stringPreco = stringSplit[stringSplit.Length-1];
                    total += Double.Parse(stringPreco);
                }
            }
            if (a != 3)
            {
                MessageBox.Show("Número de Livros selecionados invalidos!");
            }
            else
            {
                txbVbruto.Text = "R$ " + total;
                total = total - ((total/100)*desc);
                txbTotal.Text = "R$ " + total;
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(3000);
            MessageBox.Show("Dados Enviados para compra, Confirme o Pagamento pelo e-mail!");
        }
    }
}
