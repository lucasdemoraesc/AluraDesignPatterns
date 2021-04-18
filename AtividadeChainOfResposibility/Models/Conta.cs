namespace AtividadeChainOfResposibility.Models
{
    public class Conta
    {
        public string Nome { get; private set; }
        public double Saldo { get; private set; }

        public Conta(string nome, double saldo)
        {
            Nome = nome;
            Saldo = saldo;
        }
    }
}