using Observer.Interfaces;
using Observer.Models;
using System;

namespace Observer.Utils
{
    public class NotaFiscaDAO : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Nota salva no banco: " + notaFiscal.RazaoSocial);
        }
    }
}
