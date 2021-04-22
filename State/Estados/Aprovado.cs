using State.Interfaces;
using State.Models;
using System;

namespace State.Estados
{
    class Aprovado : EstadoDeUmOrcamento
    {
        private bool descontoAplicado = false;

        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (!descontoAplicado)
            {
                orcamento.Valor -= orcamento.Valor * 0.05;
                descontoAplicado = true;
            }
            else
                throw new Exception("Desconto já aplicado!");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento já está aprovado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento já foi aprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}
