using Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    public class CriadorDeItemDaNota
    {
        public string Nome { get; private set; }
        public double Valor { get; private set; }

        public ItemDaNota Constroi()
        {
            return new ItemDaNota(Nome, Valor);
        }

        public CriadorDeItemDaNota ComNome(string nome)
        {
            this.Nome = nome;
            return this;
        }

        public CriadorDeItemDaNota ComValor(double valor)
        {
            this.Valor = valor;
            return this;
        }
    }
}
