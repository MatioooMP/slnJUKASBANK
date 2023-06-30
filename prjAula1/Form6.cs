using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAula1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 janelaCadastro = new Form3();
            janelaCadastro.MdiParent = this;
            janelaCadastro.Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 janelaMenu = new Form2();
            janelaMenu.MdiParent = this;
            janelaMenu.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 janelaLogin = new Form1();
            janelaLogin.MdiParent = this;
            janelaLogin.Show();
        }

        private void saqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 janelaTransferencia = new Form5();
            janelaTransferencia.MdiParent = this;
            janelaTransferencia.Show();
        }
    }
}
