using AtividadeState.Estados;
using AtividadeState.Interfaces;
using System;

namespace AtividadeState.Models
{
    public class Conta
    {
        public IEstadoConta EstadoSaldo { get; set; }

        public string Titular { get; set; }
        public double Saldo { get; set; }
        public DateTime DataAbertura { get; set; }

        public Conta(string titular, double saldo, DateTime dataAbertura)
        {
            Titular = titular;
            Saldo = saldo;
            DataAbertura = dataAbertura;
            EstadoSaldo = new SaldoPositivo();
        }

        public void Deposita(double valor)
        {
            EstadoSaldo.Deposita(this, valor);
        }

        public void Saca(double valor)
        {
            EstadoSaldo.Saca(this, valor);
        }
    }
}
