using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            if (this.menuStrip1.Items[0].Text == "Login")
            {
                TelaLogin JanelaLogin = new TelaLogin();
                JanelaLogin.MdiParent = this;
                JanelaLogin.Show();
            }
            else
            {
                menuStrip1.Items[0].Text = "Login";
                menuStrip1.Items[1].Visible = true;
                menuStrip1.Items[2].Visible = false;
                //UsuarioLogado.Deslogar();
            }
        }

        private void saqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaTransferencia janelaTransferencia = new TelaTransferencia();
            janelaTransferencia.MdiParent = this;
            janelaTransferencia.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void alterarDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaAlterarDados JanelaAlterarDados = new TelaAlterarDados();
            JanelaAlterarDados.MdiParent = this;
            JanelaAlterarDados.Show();
        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (this.menuStrip1.Items[0].Text == "Login")
            {
                TelaLogin JanelaLogin = new TelaLogin();
                JanelaLogin.MdiParent = this;
                JanelaLogin.Show();
            }
            else
            {
                menuStrip1.Items[0].Text = "Login";
                menuStrip1.Items[1].Visible = true;
                menuStrip1.Items[2].Visible = false;
                //UsuarioLogado.Deslogar();
            }
        }

        private void cadastroToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TelaCadastrar janelaCadastro = new TelaCadastrar();
            janelaCadastro.MdiParent = this;
            janelaCadastro.Show();
        }

        private void alterarDadosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TelaAlterarDados JanelaAlterarDados = new TelaAlterarDados();
            JanelaAlterarDados.MdiParent = this;
            JanelaAlterarDados.Show();
        }

        private void criarContaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saqueToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form1 TelaDeposito = new Form1();
            TelaDeposito.MdiParent = this;
            TelaDeposito.Show();
        }
    }
}
