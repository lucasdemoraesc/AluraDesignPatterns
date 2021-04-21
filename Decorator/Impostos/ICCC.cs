using Decorator.Interfaces;
using Decorator.Models;

namespace Decorator.Impostos
{
    public class ICCC : TemplateDeImpostoCondicional
    {
        public ICCC() { }

        public ICCC(Imposto outroImposto) : base(outroImposto) { }

        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            if (orcamento.Valor > 3000)
                return true;
            return false;
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.08) + 30;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            if (orcamento.Valor >= 1000 && orcamento.Valor <= 3000)
                return orcamento.Valor * 0.07;
            else
                return orcamento.Valor * 0.05;
        }
    }
}
