using State.Models;
using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Orcamento reforma = new Orcamento();
            reforma.AdicionaItem(new Item("CANETA", 500));
            Console.WriteLine(reforma.Valor);

            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor);

            reforma.Aprova();
            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor);

            Console.ReadKey();
        }
    }
}
