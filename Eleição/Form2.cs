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
    public partial class frmeleicao : Form
    {
        double voto, c1, c2, c3, total, porcentagem;

        private void btnvoto1_Click(object sender, EventArgs e)
        {
            c1++;
            lblnome.Text = "Você votou em José Nascimento";
        }


        private void btnvoto2_Click_1(object sender, EventArgs e)
        {
            c2++;
            lblnome.Text = "Você votou em Maria Juruma";
        }

        private void btnvoto3_Click(object sender, EventArgs e)
        {
            c3++;
            lblnome.Text = "Você votou em João da Tapioca";
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frminicio fm = new frminicio();
            fm.Show();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txttotal.Clear();
            txtganhador.Clear();
            lblnome.Text = "...";
            c1 = 0;
            c2 = 0;
            c3 = 0;
            btnvoto1.Enabled = true;
            btnvoto2.Enabled = true;
            btnvoto3.Enabled = true;
        }

        public frmeleicao()
        {
            InitializeComponent();
        }


        private void btnfinalizar_Click(object sender, EventArgs e)
        {

            btnvoto1.Enabled = false;
            btnvoto2.Enabled = false;
            btnvoto3.Enabled = false;
            lblnome.Text = "...";

            total = c1 + c2 + c3;
            txttotal.Text = total.ToString();

            if (c1 > c2 && c1 > c3)
            {
                porcentagem = (c1 * 100) / total;
                txtganhador.Text = "José Nascimento, com " + c1 + " votos, sendo " + porcentagem + "% dos votos".ToString();
            }

            else if (c2 > c1 && c2 > c3)
            {
                porcentagem = (c2 * 100) / total;
                txtganhador.Text = "Maria Juruma, com " + c2 + " votos, sendo " + porcentagem + "% dos votos".ToString();
            }

            else if (c3 > c1 && c3 > c2)
            {
                porcentagem = (c3 * 100) / total;
                txtganhador.Text = "João da Tapioca, com " + c3 + " votos, sendo " + porcentagem + "% dos votos".ToString();
            }
        }
    }
}
