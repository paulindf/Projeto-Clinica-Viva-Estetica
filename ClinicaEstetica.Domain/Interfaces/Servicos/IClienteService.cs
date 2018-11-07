using ClinicaEstetica.Domain.Entidades;

namespace ClinicaEstetica.Domain.Interfaces.Servicos
{
    public interface IClienteService : IServiceBase<Cliente>
    {
        Cliente SelecionarPorCPF(string cpf);
    }
}
