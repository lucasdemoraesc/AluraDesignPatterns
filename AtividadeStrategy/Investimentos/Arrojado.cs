using AtividadeStrategy.Interfaces;
using System;

namespace AtividadeStrategy.Investimentos
{
    public class Arrojado : IInvestimento
    {
        public double Calcula(ContaBancaria conta)
        {
            int chance = new Random().Next(101);
            if (chance >= 50)
                return conta.Saldo * 0.006;
            else if (chance <= 20)
                return conta.Saldo * 0.5;
            return conta.Saldo * 0.3;

        }
    }
}
