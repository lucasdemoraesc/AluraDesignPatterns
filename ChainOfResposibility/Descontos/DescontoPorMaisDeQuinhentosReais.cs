using ChainOfResposibility.Models;

namespace ChainOfResposibility.Descontos
{
    class DescontoPorMaisDeQuinhentosReais : TemplateNode
    {
        protected override bool AplicaDescontoEm(Orcamento orcamento)
        {
            if (orcamento.Valor > 500.0)
                return true;
            else
                return false;
        }

        protected override double CalculaDesconto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }
    }
}
