using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace usandoCheckBox
{
    public partial class frmCheckBox : Form
    {
        public frmCheckBox()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            String linguagens = "As suas linguagens preferidas são: \n";            
            String a = txbEspecifique.Text;
            String[] b;
            if (ckbC.Checked)
            {
               linguagens += "C#\n";
            }
            if (ckbJava.Checked)
            {
                linguagens += "Java\n";
            }
            if (ckbPHP.Checked)
            {
                linguagens += "PHP\n";
            }
            if (ckbVisualB.Checked)
            {
                linguagens += "Visual Basic .NET\n";
            }
            if (ckbOutras.Checked)
            {
                b = a.Split(',');
                for (int i = 0; i < b.Length; i++)
                {
                    linguagens += b[i] + "\n";
                }
            }





            MessageBox.Show(linguagens);
        }

        private void ckbOutras_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbOutras.Checked)
            {
                txbEspecifique.Enabled = true;
            }
            else
            {
                txbEspecifique.Enabled = false;
            }
        }
    }
}
