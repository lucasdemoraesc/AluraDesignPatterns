using ChainOfResposibility.Interfaces;
using ChainOfResposibility.Models;

namespace ChainOfResposibility.Descontos
{
    class DescontoPorMaisDeQuinhentosReais : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Valor > 500.0)
                return orcamento.Valor * 0.07;
            else
                return Proximo.Desconta(orcamento);
        }
    }
}
