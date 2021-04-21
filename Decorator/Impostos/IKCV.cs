using System.Linq;
using Decorator.Interfaces;
using Decorator.Models;

namespace Decorator.Impostos
{
    public class IKCV : TemplateDeImpostoCondicional
    {
        public IKCV() { }
        public IKCV(Imposto outroImposto) : base(outroImposto) { }

        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && temItemMaiorQue100ReaisNo(orcamento);
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

        private bool temItemMaiorQue100ReaisNo(Orcamento orcamento)
        {
            return orcamento.Itens.Any(item => item.Valor > 100);
        }
    }
}
