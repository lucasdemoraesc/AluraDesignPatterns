using AtividadeChainOfResposibility.Interfaces;
using AtividadeChainOfResposibility.Models;
using System;

namespace AtividadeChainOfResposibility.Formatos
{
    public class RespostaEmCSV : IResposta
    {
        public IResposta Proximo { get; private set; }

        public RespostaEmCSV(IResposta proximoFormato)
        {
            this.Proximo = proximoFormato;
        }

        public string Responde(Requisicao requisicao, Conta conta)
        {
            if ("CSV".Equals(requisicao.Formato.ToString()))
                return String.Format("{0};{1}", conta.Nome, conta.Saldo);
            else
                return Proximo.Responde(requisicao, conta);

        }
    }
}
