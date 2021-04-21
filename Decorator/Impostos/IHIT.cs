using System.Linq;
using Decorator.Interfaces;
using Decorator.Models;

namespace Decorator.Impostos
{
    public class IHIT : TemplateDeImpostoCondicional
    {
        public IHIT() { }
        public IHIT(Imposto outroImposto) : base(outroImposto) { }

        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return existe2ItensComMesmoNomeEm(orcamento);
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.13) + 100;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * (0.01 * orcamento.Itens.Count());
        }

        private bool existe2ItensComMesmoNomeEm(Orcamento orcamento)
        {
            return orcamento.Itens
                .GroupBy(items => items.Nome)
                .Any(itemGroup => itemGroup.Count() > 1);
        }
    }
}
