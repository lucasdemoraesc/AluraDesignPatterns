using AtividadeChainOfResposibility.Models;

namespace AtividadeChainOfResposibility.Interfaces
{
    public interface IResposta
    {
        IResposta Proximo { get; }

        string Responde(Requisicao requisicao, Conta conta);
    }
}
