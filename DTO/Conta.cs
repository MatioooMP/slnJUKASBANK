using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Conta1
    {
        public int IdConta { get; set; }

        public int IdCliente { get; set; }

        public decimal Saldo { get; set; }

        public string? Status { get; set; }

        public decimal Limite { get; set; }

        public DateTime DataAbertura { get; set; }

        public DateTime DataFechamento { get; set; }

        public string SenhaConta { get; set; }
    }

}

