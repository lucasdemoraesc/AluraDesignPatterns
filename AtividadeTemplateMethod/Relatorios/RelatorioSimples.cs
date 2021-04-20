using AtividadeTemplateMethod.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeTemplateMethod.Relatorios
{
    public class RelatorioSimples : TemplateRelatorio
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("Banco XYZ");
        }

        protected override void Corpo(List<Conta> contas)
        {
            contas.ForEach(conta =>
            {
                Console.WriteLine(String.Format("Titular: {0}\tSaldo: R$ {1}",
                conta.Titular,
                conta.Saldo));
            });
        }

        protected override void Rodape()
        {
            Console.WriteLine("(11) 1234-5678");
        }
    }
}
