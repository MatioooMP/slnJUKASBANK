using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjAula1.Classes
{
    public class Conta
    {
        public int IdConta { get; set; }

        public int IdCliente { get; set; }  

        public double Saldo { get; set; }

        public string Status { get; set; } 

        public double Limite { get; set; }

        public DateTime DataAbertura { get; set; }

        public DateTime DataFechamento { get; set; }

        public Conta(int idConta, int idCliente, double saldo, string status, double limite, DateTime dataAbertura)
        {
            this.IdConta = idConta;
            this.IdCliente = idCliente;
            this.Saldo = saldo;
            this.Status = status;
            this.Limite = limite;
            this.DataAbertura = dataAbertura;
        }
                 
    }
