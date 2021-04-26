using Observer.Builders;
using Observer.Interfaces;
using Observer.Models;
using Observer.Utils;
using System;
using System.Collections.Generic;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IAcaoAposGerarNota> acoes = new List<IAcaoAposGerarNota>();
            acoes.Add(new EnviadorDeEmail());
            acoes.Add(new NotaFiscaDAO());
            acoes.Add(new EnviadorDeSms());
            acoes.Add(new Multiplicador());

            CriadorDeNotaFiscal criador = new CriadorDeNotaFiscal(acoes);
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
