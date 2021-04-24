using AtividadeState.Models;

namespace AtividadeState.Interfaces
{
    public interface IEstadoConta
    {
        void Deposita(Conta conta, double valor);
        void Saca(Conta conta, double valor);
    }
}
