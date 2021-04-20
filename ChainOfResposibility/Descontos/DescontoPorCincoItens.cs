using ChainOfResposibility.Interfaces;
using ChainOfResposibility.Models;

namespace ChainOfResposibility.Descontos
{
    public class DescontoPorCincoItens : TemplateNode
    {
        protected override bool AplicaDescontoEm(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 5)
                return true;
            else
                return false;
        }

        protected override double CalculaDesconto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }
    }
}
