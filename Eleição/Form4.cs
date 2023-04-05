using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eleição
{
    public partial class frmtabuada : Form
    {
        double num, i, conta;

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            txttabuada.Clear();
            txtnum.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frminicio fm = new frminicio();
            fm.Show();
        }

        private void btncalcular2_Click(object sender, EventArgs e)
        {
            num = Convert.ToDouble(txtnum.Text);
            i = 1;
            do
            {
                conta = num * i;
                txttabuada.Text = String.Concat(txttabuada.Text, "\n\n", num.ToString() + "X" + i.ToString() + "=" + conta.ToString());
                i++;
            } while (i <= 10);
        }

        private void btncalcular3_Click(object sender, EventArgs e)
        {
            num = Convert.ToDouble(txtnum.Text);
            for (i = 1; i <= 10; i++)
            {
                conta = num * i;
                txttabuada.Text = String.Concat(txttabuada.Text, "\n\n", num.ToString() + "X" + i.ToString() + "=" + conta.ToString());
            }
        }

        public frmtabuada()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            num = Convert.ToDouble(txtnum.Text);
            i = 1;
            while(i <= 10)
            {
                conta = num * i;
                txttabuada.Text = String.Concat(txttabuada.Text,"\n\n", num.ToString() + "X" + i.ToString() + "=" + conta.ToString());
                i++;
            }
        }
    }
}
