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

        public string? Status { get; set; }

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

        public double Depositar(double valorDeposito)
        {
            //this.Saldo += valorDeposito;
            this.Saldo = this.Saldo + valorDeposito;
            return this.Saldo;
        }

        public double Sacar(double valorSaque)
        {
            if (valorSaque > this.Saldo)
            {
                throw new Exception("Não foi possivel fazer este saque por falta de Saldo!");
            }
            else if (valorSaque <= 0)
            {
                throw new Exception("Saque impossível!");
            }
            else
            {
                this.Saldo = this.Saldo - valorSaque;
            }

            return this.Saldo;

        }


    }
}
