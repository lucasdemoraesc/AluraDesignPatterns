using Strategy.Interfaces;
using Strategy.Models;

namespace Strategy.Impostos
{
    public class ICMS : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }
    }
}
