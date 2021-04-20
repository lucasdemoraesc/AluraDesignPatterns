using System;
using TemplateMethod.Impostos;
using TemplateMethod.Interfaces;
using TemplateMethod.Models;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IImposto icpp = new ICPP();
            IImposto ikcv = new IKCV();
            IImposto ihit = new IHIT();
            Orcamento orcamento = new Orcamento();

            orcamento.AdicionaItem(new Item("CANETA", 250));
            orcamento.AdicionaItem(new Item("LAPIS", 251));
            orcamento.AdicionaItem(new Item("BORRACHA", 250));

            CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            calculador.RealizaCalculo(orcamento, icpp);
            calculador.RealizaCalculo(orcamento, ikcv);
            calculador.RealizaCalculo(orcamento, ihit);

            Console.ReadKey();
        }
    }
}
