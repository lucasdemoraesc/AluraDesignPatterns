using AtividadeStrategy.Interfaces;
using System;

namespace AtividadeStrategy.Investimentos
{
    public class Moderado : IInvestimento
    {
        public double Calcula(ContaBancaria conta)
        {
            if (new Random().Next(2) == 0)
                return conta.Saldo * 0.025;
            return conta.Saldo * 0.007;
        }
    }
}
