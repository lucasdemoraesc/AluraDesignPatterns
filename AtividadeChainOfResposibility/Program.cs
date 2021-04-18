using AtividadeChainOfResposibility.Formatos;
using AtividadeChainOfResposibility.Interfaces;
using AtividadeChainOfResposibility.Models;
using System;

namespace AtividadeChainOfResposibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Requisicao requisicao = new Requisicao(EFormato.PORCENTO);
            FormatadorDeConta formatador = new FormatadorDeConta();
            Conta conta = new Conta("Lucas", 1500);

            string result = formatador.Formata(requisicao, conta);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
