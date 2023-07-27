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

            if (txtcpf.TextLength < 11 || txtSenha.TextLength < 6)

            {
                lblMensagem.Text = "Preencha o campo corretamente";
            }

            else

            {
                if (txtcpf.Text == "12312312312" && txtSenha.Text == "123456")

                {
                    lblMensagem.Text = "Usuário valido";
                    var telamenu = new Form2();
                    this.Hide();
                    telamenu.Show();
                }

                else

                {

                    lblMensagem.Text = "Usuário inválido";

                }

            }
            
            
        }
    }
}