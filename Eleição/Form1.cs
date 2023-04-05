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
    public partial class frminicio : Form
    {
        public frminicio()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void eleiçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmeleicao fm = new frmeleicao();
            fm.Show();
        }

        private void combustívelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmcomb fm = new frmcomb();
            fm.Show();
        }

        private void tabuadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmtabuada fm = new frmtabuada();
            fm.Show();
        }
    }
}
