using Decorator.Interfaces;
using Decorator.Impostos;
using Decorator.Models;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto impostos = new ImpostoMuitoAlto(new ICMS());

            Orcamento orcamento = new Orcamento();
            orcamento.AdicionaItem(new Item("CANETA", 500));

            double valor = impostos.Calcula(orcamento);

            Console.WriteLine(valor);
            Console.ReadKey();
        }
    }
}
