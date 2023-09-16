using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class Conta
    {
        public  int IdConta { get; set; }

        public int IdCliente { get; set; }

        public decimal Saldo { get; set; }

        public string Status { get; set; }

        public DateTime DataAbertura { get; set; }

        public string SenhaConta { get; set; }

        public string TipoConta { get; set; }

       
    }

}

