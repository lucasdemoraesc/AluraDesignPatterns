using AtividadeTemplateMethod.Models;
using AtividadeTemplateMethod.Relatorios;
using System;
using System.Collections.Generic;

namespace AtividadeTemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Conta> contas = new List<Conta>();
            RelatorioSimples relatorioSimples = new RelatorioSimples();
            RelatorioComplexo relatorioComplexo = new RelatorioComplexo();

            contas.Add(new Conta("Teste1", 1200, "1234-x", "131750"));
            contas.Add(new Conta("Teste2", 345, "1254-y", "154896"));
            contas.Add(new Conta("Teste3", 1567.09, "1256-x", "152035"));
            contas.Add(new Conta("Teste4", 13089.67, "1414-x", "104587"));
            contas.Add(new Conta("Teste5", 678.4, "0548-y", "854120"));
            contas.Add(new Conta("Teste6", 12.9, "0529-x", "0365820"));

            relatorioComplexo.Imprime(contas);
            Console.WriteLine("# ----------------------------------------------------------------------------- #");
            relatorioSimples.Imprime(contas);
            Console.ReadKey();
        }
    }
}
