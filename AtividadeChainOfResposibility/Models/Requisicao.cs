namespace AtividadeChainOfResposibility.Models
{
    public class Requisicao
    {
        public EFormato Formato { get; private set; }

        public Requisicao(EFormato formato)
        {
            this.Formato = formato;
        }
    }
}
