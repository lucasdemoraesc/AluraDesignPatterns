using ChainOfResposibility.Models;

namespace ChainOfResposibility.Interfaces
{
    public interface IDesconto
    {
        IDesconto Proximo { get; set; }

        double Desconta(Orcamento orcamento);
    }
}
