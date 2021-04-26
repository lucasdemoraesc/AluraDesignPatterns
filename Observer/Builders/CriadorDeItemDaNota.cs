using Observer.Models;

namespace Observer.Builders
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
