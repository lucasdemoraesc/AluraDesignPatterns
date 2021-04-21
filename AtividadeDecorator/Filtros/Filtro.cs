using AtividadeDecorator.Models;
using System.Collections.Generic;

namespace AtividadeDecorator.Filtros
{
    public abstract class Filtro
    {
        public Filtro OutroFiltro { get; private set; }
        protected List<Conta> ContasFiltradas;

        public Filtro()
        {
            OutroFiltro = null;
            ContasFiltradas = new List<Conta>();
        }

        public Filtro(Filtro outroFiltro)
        {
            OutroFiltro = outroFiltro;
            ContasFiltradas = new List<Conta>();
        }

        protected virtual List<Conta> AplicaOutroFiltro(List<Conta> contas)
        {
            if (OutroFiltro != null)
                return OutroFiltro.Filtra(contas);
            return new List<Conta>();
        }

        public abstract List<Conta> Filtra(List<Conta> contas);
    }
}
