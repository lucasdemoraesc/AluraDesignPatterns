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
                .ComItem(new ItemDaNota("Item1", 200))
                .ComItem(new ItemDaNota("Item2", 300))
                .NaDataAtual()
                .ComObservacoes("Minhas observações");

            NotaFiscal nf = criador.Constroi();

            Console.WriteLine(nf.ValorBruto);
            Console.WriteLine(nf.Impostos);
            Console.ReadKey();
        }
    }
}
