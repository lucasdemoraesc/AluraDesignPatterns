using AtividadeChainOfResposibility.Interfaces;
using AtividadeChainOfResposibility.Models;
using System;

namespace AtividadeChainOfResposibility.Formatos
{
    public class RespostaEmPorcento : IResposta
    {
        public IResposta Proximo { get; private set; }

        public RespostaEmPorcento(IResposta proximoFormato)
        {
            this.Proximo = proximoFormato;
        }

        public string Responde(Requisicao requisicao, Conta conta)
        {
            if ("PORCENTO".Equals(requisicao.Formato.ToString()))
                return String.Format("{0}%{1}", conta.Nome, conta.Saldo);
            else
                return Proximo.Responde(requisicao, conta);
        }
    }
}
