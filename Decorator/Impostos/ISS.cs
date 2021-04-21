using Decorator.Interfaces;
using Decorator.Models;
using System;

namespace Decorator.Impostos
{
    public class ISS : TemplateDeImpostoCondicional
    {
        public ISS() { }
        public ISS(Imposto outroImposto) : base(outroImposto) { }

        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return true;
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            throw new Exception("ISS deve usar máxima taxação");
        }
    }
}
