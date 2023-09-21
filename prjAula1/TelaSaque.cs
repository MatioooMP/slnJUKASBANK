using DTO;
using prjAula1.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAula1
{
    public partial class TelaSaque : Form
    {
        public TelaSaque()
        {
            InitializeComponent();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            try
            {
                Conta conta = new Conta();
                foreach (var item in UsuarioLogado.Contas)
                {
                    if (item.IdConta == UsuarioLogado.ContaLogada)
                    {
                        conta = item;
                    }
                }

                if (Convert.ToDecimal(txtSaldoSacar.Text) <= conta.Saldo && txtSenhaConfirmar.Text == conta.SenhaConta)
                {
                    //Criando uma conexão
                    SqlConnection conexao =
                           new SqlConnection(ConfigurationManager.ConnectionStrings["prjAula1.Properties.Settings.strConexao"].ToString());
                    //Criando um comando
                    SqlCommand cmd = new SqlCommand();


                    //criando texto do comando, tipo e conexão que será usada
                    cmd.CommandText = "pu_AtualizarConta";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexao;

                    conta.Saldo = conta.Saldo - Convert.ToDecimal(txtSaldoSacar.Text) ;
                    //inserindo parâmetros à procedure
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("idConta", UsuarioLogado.ContaLogada);//15
                    cmd.Parameters.AddWithValue("dataCriacaoConta", conta.DataAbertura);
                    cmd.Parameters.AddWithValue("saldo", conta.Saldo);
                    cmd.Parameters.AddWithValue("tipoConta", conta.TipoConta);
                    cmd.Parameters.AddWithValue("statusConta", conta.Status);
                    cmd.Parameters.AddWithValue("senhaConta", conta.SenhaConta);


                    //5
                    //12
                    //15



                    //abrir a conexão
                    conexao.Open();


                    cmd.ExecuteNonQuery(); //executa o comando no BD
                    conexao.Close();
                    MessageBox.Show("Saque feito com sucesso!!!", "Info",
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
    }
    }

