using AtividadeDecorator.Filtros;
using AtividadeDecorator.Models;
using System;
using System.Collections.Generic;

namespace AtividadeDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Filtro filtros = new FiltroSaldoMenorQue100(
                new FiltroSaldoMaiorQue500Mil(
                    new FiltroContasAbertasNoMes()));

            List<Conta> contas = new List<Conta>();
            contas.Add(new Conta("Teste1", 100, new DateTime(2000, 12, 23)));
            contas.Add(new Conta("Teste2", 400, new DateTime(2021, 04, 23)));
            contas.Add(new Conta("Teste3", 95, new DateTime(2000, 12, 23)));
            contas.Add(new Conta("Teste4", 510564, new DateTime(2000, 12, 23)));
            contas.Add(new Conta("Teste5", 800000, new DateTime(2000, 12, 23)));
            contas.Add(new Conta("Teste6", 300, new DateTime(2021, 04, 25)));
            contas.Add(new Conta("Teste7", 500, new DateTime(2000, 12, 23)));
            contas.Add(new Conta("Teste8", 502120, new DateTime(2000, 12, 23)));
            contas.Add(new Conta("Teste9", 94, new DateTime(2000, 12, 23)));

            filtros.Filtra(contas).ForEach(conta =>
            {
                Console.WriteLine(String.Format("{0}: {1} - {2}", conta.Titular, conta.Saldo, conta.DataAbertura));
            });

            Console.ReadKey();
        }
    }
}
