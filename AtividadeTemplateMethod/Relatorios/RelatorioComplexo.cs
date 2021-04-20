using AtividadeTemplateMethod.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeTemplateMethod.Relatorios
{
    public class RelatorioComplexo : TemplateRelatorio
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("Banco XYZ");
            Console.WriteLine("Avenida Paulista, 1234");
            Console.WriteLine("(11) 1234-5678");
        }

        protected override void Corpo(List<Conta> contas)
        {
            contas.ForEach(conta =>
            {
                Console.WriteLine(String.Format("Titular: {0}\tAgencia: {1}\tConta: {2}\tSaldo: R$ {3}",
                conta.Titular,
                conta.Agencia,
                conta.Numero,
                conta.Saldo));
            });
        }

        protected override void Rodape()
        {
            Console.WriteLine("banco@xyz.com.br");
            Console.WriteLine(DateTime.Now);
        }
    }
}
