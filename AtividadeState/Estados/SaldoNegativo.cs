using AtividadeState.Interfaces;
using AtividadeState.Models;
using System;

namespace AtividadeState.Estados
{
    class SaldoNegativo : IEstadoConta
    {
        public void Deposita(Conta conta, double valor)
        {
            conta.Saldo += valor * 0.95;
            if (conta.Saldo > 0)
                conta.EstadoSaldo = new SaldoPositivo();
        }

        public void Saca(Conta conta, double valor)
        {
            throw new Exception("Não há saldo suficiente");
        }
    }
}
