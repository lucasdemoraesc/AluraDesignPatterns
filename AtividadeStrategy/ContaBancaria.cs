namespace AtividadeStrategy
{
    public class ContaBancaria
    {
        public double Saldo { get; private set; }

        public ContaBancaria(double saldo)
        {
            Saldo = saldo;
        }

        public void Deposita(double valor)
        {
            Saldo += valor;
        }
    }
}
