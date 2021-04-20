using AtividadeTemplateMethod.Models;
using System.Collections.Generic;

namespace AtividadeTemplateMethod.Relatorios
{
    public abstract class TemplateRelatorio
    {
        protected abstract void Cabecalho();
        protected abstract void Rodape();
        protected abstract void Corpo(List<Conta> contas);

        public void Imprime(List<Conta> contas)
        {
            Cabecalho();
            Corpo(contas);
            Rodape();
        }
    }
}
