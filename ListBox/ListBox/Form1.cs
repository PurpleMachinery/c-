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
            for (int i = 0; i < 9; i++)
            {
                if (lbLivros.GetSelected(i) == true)
                {
                    if (i == 0) total += 55;
                    if (i == 1) total += 47;
                    if (i == 2) total += 23;
                    if (i == 3) total += 35;
                    if (i == 4) total += 55;
                    if (i == 5) total += 55;
                    if (i == 6) total += 35;
                    if (i == 7) total += 45;
                    if (i == 8) total += 25;
                }                
            }
            txbTotal.Text = "" + total;
            if (a != 3) MessageBox.Show("Quantidade invalida: " + a);
        }
    }
}
