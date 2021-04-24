using AtividadeState.Models;
using System;

namespace AtividadeState
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta("Teste", 500, DateTime.Now);
            Console.WriteLine("Saldo inicial: " + conta.Saldo);

            conta.Saca(100);
            conta.Saca(100);

            Console.WriteLine("Após saques: " + conta.Saldo);

            Console.ReadKey();
        }
    }
}
