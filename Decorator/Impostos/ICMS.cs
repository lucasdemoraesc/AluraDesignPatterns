using Decorator.Interfaces;
using Decorator.Models;
using System;

namespace Decorator.Impostos
{
    public class ICMS : TemplateDeImpostoCondicional
    {
        public ICMS() { }
        public ICMS(Imposto outroImposto) : base(outroImposto) { }

        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return true;
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            throw new Exception("ICMS deve usar máxima taxação");
        }
    }
}
