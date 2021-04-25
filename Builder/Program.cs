using Builder.Builders;
using Builder.Models;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            CriadorDeNotaFiscal criador = new CriadorDeNotaFiscal();
            criador.ParaEmpresa("Testes S/a")
                .ComCnpj("23456789000112")
                .Com(new ItemDaNota("Item1", 200))
                .Com(new ItemDaNota("Item2", 300))
                .NaData(new DateTime(2020, 11, 12))
                .ComObservacoes("Minhas observações");

            NotaFiscal nf = criador.Constroi();

            Console.WriteLine(nf.ValorBruto);
            Console.WriteLine(nf.Impostos);
            Console.WriteLine(nf.DataDeEmissao);
            Console.ReadKey();
        }
    }
}
