using AtividadeDecorator.Models;
using System.Collections.Generic;
using System.Linq;

namespace AtividadeDecorator.Filtros
{
    public class FiltroSaldoMenorQue100 : Filtro
    {
        public FiltroSaldoMenorQue100() { }
        public FiltroSaldoMenorQue100(Filtro outroFiltro) : base(outroFiltro) { }


        public override List<Conta> Filtra(List<Conta> contas)
        {
            ContasFiltradas.AddRange(contas.Where(conta => conta.Saldo < 100).ToList());
            ContasFiltradas.AddRange(AplicaOutroFiltro(contas));
            return ContasFiltradas;
        }
    }
}
