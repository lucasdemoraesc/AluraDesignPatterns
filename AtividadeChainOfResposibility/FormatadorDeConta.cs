using AtividadeChainOfResposibility.Formatos;
using AtividadeChainOfResposibility.Interfaces;
using AtividadeChainOfResposibility.Models;

namespace AtividadeChainOfResposibility
{
    public class FormatadorDeConta
    {
        public string Formata(Requisicao requisicao, Conta conta)
        {
            IResposta f3 = new RespostaEmPorcento(null);
            IResposta f2 = new RespostaEmCSV(f3);
            IResposta f1 = new RespostaEmXML(f2);

            return f1.Responde(requisicao, conta);
        }
    }
}
