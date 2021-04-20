using ChainOfResposibility.Interfaces;
using ChainOfResposibility.Models;
using System;

namespace ChainOfResposibility.Descontos
{
    public abstract class TemplateNode : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (AplicaDescontoEm(orcamento))
                return CalculaDesconto(orcamento);
            else
                return ProximoNode(orcamento);
        }

        protected abstract bool AplicaDescontoEm(Orcamento orcamento);

        protected abstract double CalculaDesconto(Orcamento orcamento);

        protected virtual double ProximoNode(Orcamento orcamento)
        {
            return Proximo.Desconta(orcamento);
        }
    }
}
