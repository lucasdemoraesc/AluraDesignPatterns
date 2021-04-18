using AtividadeChainOfResposibility.Interfaces;
using AtividadeChainOfResposibility.Models;
using System;

namespace AtividadeChainOfResposibility.Formatos
{
    public class RespostaEmXML : IResposta
    {
        public IResposta Proximo { get; private set; }

        public RespostaEmXML(IResposta proximoFormato)
        {
            this.Proximo = proximoFormato;
        }

        public string Responde(Requisicao requisicao, Conta conta)
        {
            if ("XML".Equals(requisicao.Formato.ToString()))
                return String.Format("<nome>{0}</nome><saldo>{1}</saldo>", conta.Nome, conta.Saldo);
            else
                return Proximo.Responde(requisicao, conta);
        }
    }
}
