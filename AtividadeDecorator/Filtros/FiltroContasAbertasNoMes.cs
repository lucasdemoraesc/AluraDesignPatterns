using AtividadeDecorator.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AtividadeDecorator.Filtros
{
    public class FiltroContasAbertasNoMes : Filtro
    {
        public FiltroContasAbertasNoMes() { }
        public FiltroContasAbertasNoMes(Filtro outroFiltro) : base(outroFiltro) { }

        public override List<Conta> Filtra(List<Conta> contas)
        {
            ContasFiltradas.AddRange(contas.Where(conta =>
                conta.DataAbertura.Month == DateTime.Now.Month &&
                conta.DataAbertura.Year == DateTime.Now.Year).ToList());
            ContasFiltradas.AddRange(AplicaOutroFiltro(contas));
            return ContasFiltradas;
        }
    }
}
