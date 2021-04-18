﻿using ChainOfResposibility.Interfaces;
using ChainOfResposibility.Models;

namespace ChainOfResposibility.Descontos
{
    public class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            return 0;
        }
    }
}