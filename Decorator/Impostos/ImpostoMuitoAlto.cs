using Decorator.Interfaces;
using Decorator.Models;
using System;

namespace Decorator.Impostos
{
    class ImpostoMuitoAlto : TemplateDeImpostoCondicional
    {
        public ImpostoMuitoAlto() { }

        public ImpostoMuitoAlto(Imposto outroImposto) : base(outroImposto) { }

        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return true;
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.2;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            throw new Exception("ImpostoMuitoAlto deve usar maxima taxacao");
        }
    }
}
