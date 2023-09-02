using Microsoft.VisualBasic;
using prjAula1.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAula1
{
    public partial class TelaCadastrar : Form
    {
        public string Nome { get; set; }



        public TelaCadastrar()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSenhaCadastro.Text == txtRepetirSenha.Text)
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
                    cmd.Parameters.AddWithValue("nomeCliente", txtNome.Text);
                    cmd.Parameters.AddWithValue("dataNascimento", Convert.ToDateTime(dtpDataNascimento.Text));
                    cmd.Parameters.AddWithValue("cidade", txtCidade.Text);
                    cmd.Parameters.AddWithValue("estado", cmbEstados.Text);
                    cmd.Parameters.AddWithValue("cpf", txtCpfCadastro.Text);
                    cmd.Parameters.AddWithValue("senha", txtSenhaCadastro.Text);
                    cmd.Parameters.AddWithValue("email",txtEmail.Text);


                    //abrir a conexão
                    conexao.Open();
                    cmd.ExecuteNonQuery(); //executa o comando no BD
                    conexao.Close();
                    MessageBox.Show("Cliente Cadastrado com sucesso!!!", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    UtilUI.LimpaForm(this);
                }
                else
                {
                    throw new Exception("Os campos de senha não coincidem!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }











            //if (txtCpfCadastro.Text == string.Empty || txtDataNascimento.Text == string.Empty || txtEmail.Text == string.Empty || txtNome.Text == string.Empty || txtSenhaCadastro.Text == string.Empty)
            //{
            //    MessageBox.Show("Alguma caixa esta vazia!");
            //}
            //else
            //{

            //    if (double.TryParse(txtCpfCadastro.Text, out double res) == false || txtCpfCadastro.TextLength < 11)
            //    {
            //        MessageBox.Show("Cpf errado!");

            //    }
            //    if (int.TryParse(txtSenhaCadastro.Text, out int res1) == false || txtSenhaCadastro.TextLength < 6)
            //    {
            //        MessageBox.Show("Senha errada!");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Cadastrado!");
            //        TelaCadastrar dados = new TelaCadastrar();
            //        string nome = txtNome.Text;



            //        var menu = new TelaMenu();

            //        this.Hide();
            //        menu.Show();
            //    }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
    class Cliente : TelaCadastrar
    {


        public Cliente()
        {
            
        }
    }

}






