using AtividadeState.Interfaces;
using AtividadeState.Models;
using System;

namespace AtividadeState.Estados
{
    public class SaldoPositivo : IEstadoConta
    {
        public void Deposita(Conta conta, double valor)
        {
            conta.Saldo += valor * 0.98;
        }

        public void Saca(Conta conta, double valor)
        {
            conta.Saldo -= valor;
            if (conta.Saldo < 0)
                conta.EstadoSaldo = new SaldoNegativo();
        }
    }
}
