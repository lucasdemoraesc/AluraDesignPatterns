using Observer.Interfaces;
using Observer.Models;
using System;

namespace Observer.Utils
{
    public class EnviadorDeSms : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Nota enviada por SMS: " + notaFiscal.RazaoSocial);
        }
    }
}
