using Observer.Interfaces;
using Observer.Models;
using System;

namespace Observer.Utils
{
    public class EnviadorDeEmail : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Nota enviada por E-mail:" + notaFiscal.RazaoSocial);
        }
    }
}
