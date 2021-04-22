﻿using State.Estados;
using State.Interfaces;
using System.Collections.Generic;

namespace State.Models
{
    public class Orcamento
    {
        public EstadoDeUmOrcamento EstadoAtual { get; set; }

        public double Valor { get; set; }
        public IList<Item> Itens { get; private set; }

        public Orcamento()
        {
            this.Itens = new List<Item>();
            this.EstadoAtual = new EmAprovacao();
        }

        public void AplicaDescontoExtra()
        {
            EstadoAtual.AplicaDescontoExtra(this);
        }

        public void AdicionaItem(Item item)
        {
            this.Valor += item.Valor;
            Itens.Add(item);
        }

        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }

        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }

        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }
    }
}
