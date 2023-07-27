using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjAula1.Classes;

namespace prjAula1
{
   
    public partial class Extra : Form
    {
        Conta minhaConta;
        public Extra()
        {
            InitializeComponent();
        }

        public void Extra_Load(object sender, EventArgs e)
        {
             minhaConta = new Conta
                (2,2,1000,"Ativa",1000,DateTime.Now);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void btnDepositar_Click(object sender, EventArgs e)
        {
            minhaConta.Depositar(Convert.ToDouble(valorDeposito.Text));
            MessageBox.Show(minhaConta.Saldo.ToString(), "Novo Saldo");
        }
    }
}
