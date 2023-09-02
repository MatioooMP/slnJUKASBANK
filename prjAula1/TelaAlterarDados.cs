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
    public partial class TelaAlterarDados : Form
    {
        public TelaAlterarDados()
        {
            InitializeComponent();
        }

        private void TelaAlterarDados_Load(object sender, EventArgs e)
        {
            txtAlterarCidade.Text = UsuarioLogado.Cidade;
            txtAlterarCPF.Text = UsuarioLogado.Cpf;
            txtAlterarEmail.Text = UsuarioLogado.Email;
            txtAlterarNome.Text = UsuarioLogado.NomeCliente;
            dtpAlterarDataNascimento.Text = Convert.ToString(UsuarioLogado.DataNascimento);
            cmbAlterarEstados.Text = UsuarioLogado.Estado;

        }
    }
}
