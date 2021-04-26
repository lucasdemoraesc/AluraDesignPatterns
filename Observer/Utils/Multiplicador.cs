using Observer.Interfaces;
using Observer.Models;
using System;

namespace Observer.Utils
{
    public class Multiplicador : IAcaoAposGerarNota
    {
        public double Fator { get; private set; }

        public Multiplicador(double fator = 2)
        {
            this.Fator = fator;
        }

        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine(notaFiscal.ValorBruto * Fator);
        }
    }
}
