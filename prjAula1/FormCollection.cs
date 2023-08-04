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
    public partial class FormCollection : Form
    {
        public FormCollection()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

        }

        private void FormCollection_Load(object sender, EventArgs e)
        {
            //declarando e criando vetores
            string[] meuArrayString = new string[3];
            //declarando e criando vetores com valores
            int[] meuArrayInt = { 2, 3, 7, 9, 10 };

            //colocando informação no array
            meuArrayString[0] = "Tobias";
            meuArrayString[1] = "Troldo";
            meuArrayString[2] = "Trita";
            //exibindo informação do array

            string mensagemFinal = "";
            for (int contador = 0; contador < meuArrayString.Length; contador = contador + 1)
            {
                mensagemFinal = mensagemFinal + ($"{meuArrayString[contador]}\n");
            }

            MessageBox.Show(mensagemFinal);
        }
    }
}