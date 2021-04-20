using ChainOfResposibility.Models;

namespace ChainOfResposibility.Descontos
{
    public class DescontoPorVendaCasada : TemplateNode
    {
        protected override bool AplicaDescontoEm(Orcamento orcamento)
        {
            if (aconteceuVendaCasadaEm(orcamento))
                return true;
            else
                return false;
        }

        protected override double CalculaDesconto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }

        private bool aconteceuVendaCasadaEm(Orcamento orcamento)
        {
            return existe("CANETA", orcamento) && existe("LAPIS", orcamento);
        }

        private bool existe(string nomeDoItem, Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Nome.Equals(nomeDoItem))
                    return true;
            }
            return false;
        }
    }
}
