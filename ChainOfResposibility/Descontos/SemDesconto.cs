using ChainOfResposibility.Models;
using System;

namespace ChainOfResposibility.Descontos
{
    public class SemDesconto : TemplateNode
    {
        protected override bool AplicaDescontoEm(Orcamento orcamento)
        {
            return true;
        }

        protected override double CalculaDesconto(Orcamento orcamento)
        {
            return 0;
        }

        protected override double ProximoNode(Orcamento orcamento)
        {
            throw new Exception("Não há mais descontos");
        }
    }
}
