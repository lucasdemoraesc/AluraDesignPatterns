using System;

namespace AtividadeDecorator.Models
{
    public class Conta
    {
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public DateTime DataAbertura { get; set; }

        public Conta(string titular, double saldo, DateTime dataAbertura)
        {
            Titular = titular;
            Saldo = saldo;
            DataAbertura = dataAbertura;
        }
    }
}
