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
    public partial class TelaConta : Form
    {
        public TelaConta()
        {
            InitializeComponent();
        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSenhaConta.Text == txtConfirmarSenha.Text)
                {
                    //Criando uma conexão
                    SqlConnection conexao =
                           new SqlConnection(ConfigurationManager.ConnectionStrings["prjAula1.Properties.Settings.strConexao"].ToString());

                    //Criando um comando
                    SqlCommand cmd = new SqlCommand();

                    //criando texto do comando, tipo e conexão que será usada
                    cmd.CommandText = "pi_Conta";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexao;

                    //inserindo parâmetros à procedure
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("saldo", txtSaldoConta.Text);
                    cmd.Parameters.AddWithValue("senhaConta", txtSenhaConta.Text);




                    //abrir a conexão
                    conexao.Open();
                    cmd.ExecuteNonQuery(); //executa o comando no BD
                    conexao.Close();
                    MessageBox.Show("Conta Cadastrada com sucesso!!!", "Info",
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
        }
    }
}
