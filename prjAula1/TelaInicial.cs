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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastrar janelaCadastro = new TelaCadastrar();
            janelaCadastro.MdiParent = this;
            janelaCadastro.Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaMenu janelaMenu = new TelaMenu();
            janelaMenu.MdiParent = this;
            janelaMenu.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaLogin janelaLogin = new TelaLogin();
            janelaLogin.MdiParent = this;
            janelaLogin.Show();
        }

        private void saqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaTransferencia janelaTransferencia = new TelaTransferencia();
            janelaTransferencia.MdiParent = this;
            janelaTransferencia.Show();
        }
    }
}
