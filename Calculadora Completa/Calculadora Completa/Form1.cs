using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora_Completa
{
    public partial class frmCalculadoraC : Form
    {
        double a=0;
        char c='.';
        public frmCalculadoraC()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + "9";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbVisor.Text = "";
            a = 0;
            c = '.';
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (c == '+')
            {
                a += Double.Parse(txbVisor.Text);
            }
            else if (c == '-')
            {
                a -= Double.Parse(txbVisor.Text);
            }
            else if (c == '*')
            {
                a *= Double.Parse(txbVisor.Text);
            }
            else if (c == '/')
            {
                a /= Double.Parse(txbVisor.Text);                
            }
            txbVisor.Text = "" + a;
            a = 0;
            c = '.';
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (a == 0 && c == '.')
            {
                a = Double.Parse(txbVisor.Text);
                txbVisor.Text = "";
            }
            else 
            {
                a = Calculo(a, c, txbVisor.Text);
                txbVisor.Text = "";
            }
            c = '+';
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (a == 0 && c == '.')
            {
                a = Double.Parse(txbVisor.Text);
                txbVisor.Text = "";
            }
            else
            {
                a = Calculo(a, c, txbVisor.Text);
                txbVisor.Text = "";
            }
            c = '-';
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (a == 0 && c == '.')
            {
                a = Double.Parse(txbVisor.Text);
                txbVisor.Text = "";
            }
            else
            {
                a = Calculo(a, c, txbVisor.Text);
                txbVisor.Text = "";
            }
            c = '/';
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (a == 0 && c == '.')
            {
                a = Double.Parse(txbVisor.Text);
                txbVisor.Text = "";
            }
            else
            {
                a = Calculo(a, c, txbVisor.Text);
                txbVisor.Text = "";
            }
            c = '*';
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txbVisor.Text += "0";
        }
        private void btnVirgula_Click(object sender, EventArgs e)
        {
            for (int i = 0; i == txbVisor.Text.Length - 1; i++)
            {
                if (txbVisor.Text[i] != ',') txbVisor.Text += ',';
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            txbVisor.Text = Position(txbVisor.Text);
        }

        public static String Position(String a)
        {
            String b="";
            for (int i = 0; i < a.Length - 1; i++)
            {
                b += a[i];
            }
            String c = b;
            b = "";
            return c;
            
        }
        public static double Calculo(double a, char c, String txbVisor)
        {
            if (c == '+')
            {
                a = a + Double.Parse(txbVisor);
                txbVisor = "";
            }
            else if (c == '-')
            {
                a = a - Double.Parse(txbVisor);
                txbVisor = "";
            }
            else if (c == '/')
            {
                a = a / Double.Parse(txbVisor);
                txbVisor = "";
            }
            else if (c == '*')
            {
                a = a * Double.Parse(txbVisor);
                txbVisor= "";
            }
            return a;
        }
    }
}
