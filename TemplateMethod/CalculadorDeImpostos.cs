using TemplateMethod.Interfaces;
using TemplateMethod.Models;
using System;

namespace TemplateMethod
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, IImposto imposto)
        {
            double result = imposto.Calcula(orcamento);
            Console.WriteLine(result);
        }
    }
}
