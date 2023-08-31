using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace prjAula1
{
    public static class UsuarioLogado
    {
        public static int idCliente { get; set; }
        public static string nomeCliente { get; set; }
        public static string cpf { get; set; }
        public static string email { get; set; }
        public static DateTime dataNascimento { get; set; }
        public static string cidade { get; set; }
        public static string senha  { get; set; }
        public static string estado { get; set; }
    }
}
