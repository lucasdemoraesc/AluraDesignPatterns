using AtividadeStrategy.Interfaces;
using AtividadeStrategy.Investimentos;
using System;

namespace AtividadeStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            IInvestimento conservador = new Conservador();
            IInvestimento moderado = new Moderado();
            IInvestimento arrojado = new Arrojado();

            ContaBancaria conta = new ContaBancaria(1000);

            RealizadorDeInvestimentos realizadorDeInvestimentos = new RealizadorDeInvestimentos();
            realizadorDeInvestimentos.InvesteSaldo(conta, conservador);
            realizadorDeInvestimentos.InvesteSaldo(conta, moderado);
            realizadorDeInvestimentos.InvesteSaldo(conta, arrojado);

            Console.ReadKey();
        }
    }
}
