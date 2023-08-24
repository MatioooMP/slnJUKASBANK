using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Numerics;
using prjAula1.Classes;

namespace prjAula1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var menu = new Form3();
            this.Hide();
            menu.Show();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Criando uma conexão
            SqlConnection conexao =
            new SqlConnection(ConfigurationManager.ConnectionStrings["prjAula1.Properties.Settings.strConexao"].ToString());
            SqlDataReader leitor; //declarando uma variável do tipo leitor de dados

            //Criando um comando
            SqlCommand cmd = new SqlCommand();

            //criando texto do comando, tipo e conexão que será usada
            cmd.CommandText = "psValidaLogin";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexao;

            //passando parâmetros necessários
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("cpf", txtcpf.Text);
            cmd.Parameters.AddWithValue("senha", txtSenha.Text); 


        }
    }
}