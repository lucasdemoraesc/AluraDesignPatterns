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
            Imposto iss = new ISS(
                new ICMS(
                    new IKCV(
                        new ICPP(
                            new ICCC(
                                new IHIT()
                                )
                            )
                        )
                    )
                );

            Orcamento orcamento = new Orcamento();
            orcamento.AdicionaItem(new Item("CANETA", 500));

            double valor = iss.Calcula(orcamento);

            Console.WriteLine(valor);
            Console.ReadKey();
        }
    }
}
