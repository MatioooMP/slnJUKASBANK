﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using DTO;

namespace prjAula1
{
    public static class UsuarioLogado
    {
        public static int IdCliente { get; set; }
        public static string NomeCliente { get; set; }
        public static string Cpf { get; set; }
        public static string Email { get; set; }
        public static DateTime DataNascimento { get; set; }
        public static string Cidade { get; set; }
        public static string Senha  { get; set; }
        public static string Estado { get; set; }




        public static List<Conta>Contas = new List<Conta>();
    }
}
