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
    public partial class frmcomb : Form
    {
        public frmcomb()
        {
            InitializeComponent();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            double litros, dp, pl;
            string comb;

            comb = Convert.ToString(txtcomb.Text);
            litros = Convert.ToDouble(txtlitros.Text);

            if(comb == "A" || comb == "a")
            {
                if(litros <= 20)
                {
                    dp = 4.90 - ((4.90 * 3) / 100);
                    pl = dp * litros;
                    txtvalor.Text = "R$" + pl;
                }
                else
                {
                    dp = 4.90 - ((4.90 * 5) / 100);
                    pl = dp * litros;
                    txtvalor.Text = "R$" + pl;
                }
            }

            if(comb == "G" || comb == "g")
            {
                if (litros <= 20)
                {
                    dp = 5.50 - ((5.50 * 4) / 100);
                    pl = dp * litros;
                    txtvalor.Text = "R$" + pl;
                }
                else
                {
                    dp = 5.50 - ((5.50 * 6) / 100);
                    pl = dp * litros;
                    txtvalor.Text = "R$" + pl;
                }
            }
        }

        private void btnlimp_Click(object sender, EventArgs e)
        {
            txtcomb.Clear();
            txtlitros.Clear();
            txtvalor.Clear();
            txtcomb.Focus();
        }

        private void btnvolt_Click(object sender, EventArgs e)
        {
            this.Hide();
            frminicio fm = new frminicio();
            fm.Show();
        }
    }
}
