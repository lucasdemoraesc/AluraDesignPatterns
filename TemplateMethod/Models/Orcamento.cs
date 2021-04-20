using System.Collections.Generic;

namespace TemplateMethod.Models
{
    public class Orcamento
    {
        public double Valor { get; private set; }
        public IList<Item> Itens { get; private set; }

        public Orcamento()
        {
            this.Itens = new List<Item>();
        }

        public void AdicionaItem(Item item)
        {
            this.Valor += item.Valor;
            Itens.Add(item);
        }
    }
}
