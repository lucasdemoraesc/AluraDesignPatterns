using AtividadeDecorator.Models;
using System.Collections.Generic;
using System.Linq;

namespace AtividadeDecorator.Filtros
{
    public class FiltroSaldoMaiorQue500Mil : Filtro
    {
        public FiltroSaldoMaiorQue500Mil() { }
        public FiltroSaldoMaiorQue500Mil(Filtro outroFiltro) : base(outroFiltro) { }

        public override List<Conta> Filtra(List<Conta> contas)
        {
            ContasFiltradas.AddRange(contas.Where(conta => conta.Saldo > 500000).ToList());
            ContasFiltradas.AddRange(AplicaOutroFiltro(contas));
            return ContasFiltradas;
        }
    }
}
