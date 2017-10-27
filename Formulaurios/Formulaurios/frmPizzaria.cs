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
    public partial class frmPizzaria : Form
    {
        public frmPizzaria()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double total=0;
            if (cbSabor.Text.ElementAt(0) == 'M' && cbSabor.Text.ElementAt(1) == 'u' && cbSabor.Text.ElementAt(2) == 's' && cbSabor.Text.ElementAt(3) == 's')
            {
                total += 19;
            }
            else if (cbSabor.Text.ElementAt(0) == 'P' && cbSabor.Text.ElementAt(1) == 'e' && cbSabor.Text.ElementAt(2) == 'p' && cbSabor.Text.ElementAt(3) == 'e') 
            {
                total += 21;
            }
            else if (cbSabor.Text.ElementAt(0) == 'P' && cbSabor.Text.ElementAt(1) == 'o' && cbSabor.Text.ElementAt(2) == 'r' && cbSabor.Text.ElementAt(3) == 't') 
            { 
                total +=24;
            }
            if (!rdbSem.Checked)
            {
                if (rdbCatupiri.Checked)
                {
                    total += 4;
                }
                else if (rdbCheddar.Checked) 
                {
                    total += 3;
                }
            }
            if (ckbBacon.Checked)
            {
                total += 7;
            }
            if (ckbMRecheio.Checked)
            {
                total += 6;
            }


            mtxbResult.Text = "" + total;
        }
    }
}
