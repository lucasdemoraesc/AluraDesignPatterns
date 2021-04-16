using AtividadeStrategy.Interfaces;
using System;

namespace AtividadeStrategy
{
    public class RealizadorDeInvestimentos
    {
        public void InvesteSaldo(ContaBancaria conta, IInvestimento investimento)
        {
            double rendimentoBruto = investimento.Calcula(conta);
            double imposto = rendimentoBruto * 0.25;
            double rendimentoLiquido = rendimentoBruto - imposto;

            conta.Deposita(rendimentoLiquido);

            Console.WriteLine(String.Format("Rendimento Bruto: {0}", rendimentoBruto));
            Console.WriteLine(String.Format("Rendimento Liquido: {0}", rendimentoLiquido));
            Console.WriteLine(String.Format("Imposto: {0}", imposto));
            Console.WriteLine(String.Format("Novo Saldo: {0}\n", conta.Saldo));
        }
    }
}
