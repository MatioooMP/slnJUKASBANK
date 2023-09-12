using prjAula1.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Numerics;
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

        public void SalvarCliente()
        {
            try
            {
                //Criando uma conexão
                SqlConnection conexao =
                       new SqlConnection(ConfigurationManager.ConnectionStrings["prjAula1.Properties.Settings.strConexao"].ToString());

                //Criando um comando
                SqlCommand cmd = new SqlCommand();

                //criando texto do comando, tipo e conexão que será usada
                cmd.CommandText = "pi_Cliente";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexao;

                //inserindo parâmetros à procedure
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("nomeCliente", txtAlterarNome.Text);
                cmd.Parameters.AddWithValue("dataNascimento", Convert.ToDateTime(dtpAlterarDataNascimento.Text));
                cmd.Parameters.AddWithValue("cidade", txtAlterarCidade.Text);
                cmd.Parameters.AddWithValue("estado", cmbAlterarEstados.Text);
                cmd.Parameters.AddWithValue("cpf", txtAlterarCPF.Text);
                cmd.Parameters.AddWithValue("email", txtAlterarEmail.Text);


                //abrir a conexão
                conexao.Open();
                cmd.ExecuteNonQuery(); //executa o comando no BD
                conexao.Close();
                MessageBox.Show("Cliente cadastrado com sucesso!!!", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                UtilUI.LimpaForm(this);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TelaAlterarDados_Load_1(object sender, EventArgs e)
        {
            txtAlterarCidade.Text = UsuarioLogado.Cidade;
            txtAlterarCPF.Text = UsuarioLogado.Cpf;
            txtAlterarEmail.Text = UsuarioLogado.Email;
            txtAlterarNome.Text = UsuarioLogado.NomeCliente;
            dtpAlterarDataNascimento.Text = Convert.ToString(UsuarioLogado.DataNascimento);
            cmbAlterarEstados.Text = UsuarioLogado.Estado;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtConfirmarSenha.Text == UsuarioLogado.Senha)
                {
                    //Criando uma conexão
                    SqlConnection conexao =
                           new SqlConnection(ConfigurationManager.ConnectionStrings["prjAula1.Properties.Settings.strConexao"].ToString());
                    //Criando um comando
                    SqlCommand cmd = new SqlCommand();


                    //criando texto do comando, tipo e conexão que será usada
                    cmd.CommandText = "pu_AtualiazarCliente2";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexao;

                 
                  
                    //inserindo parâmetros à procedure
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("idCliente", UsuarioLogado.IdCliente);
                    cmd.Parameters.AddWithValue("nomeCliente", txtAlterarNome.Text);
                    cmd.Parameters.AddWithValue("dataNascimento", Convert.ToDateTime(dtpAlterarDataNascimento.Text));
                    cmd.Parameters.AddWithValue("cidade", txtAlterarCidade.Text);
                    cmd.Parameters.AddWithValue("estado", cmbAlterarEstados.Text);
                    cmd.Parameters.AddWithValue("cpf", txtAlterarCPF.Text);
                    cmd.Parameters.AddWithValue("email", txtAlterarEmail.Text);




                    //abrir a conexão
                    conexao.Open();
                    cmd.ExecuteNonQuery(); //executa o comando no BD
                    conexao.Close();
                    MessageBox.Show("Cliente Alterado com sucesso!!!", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    UtilUI.LimpaForm(this); 
                }
                    
                else
                {
                    throw new Exception("Senha incorreta!");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbAlterarEstados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
