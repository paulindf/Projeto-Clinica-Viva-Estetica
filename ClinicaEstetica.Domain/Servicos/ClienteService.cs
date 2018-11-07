using ClinicaEstetica.Domain.Entidades;
using ClinicaEstetica.Domain.Interfaces.Repositorios;
using ClinicaEstetica.Domain.Interfaces.Servicos;

namespace ClinicaEstetica.Domain.Servicos
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private IClienteRepositorio repositorio;

        public ClienteService(IClienteRepositorio repositorio)
            : base(repositorio) => this.repositorio = repositorio;

        public Cliente SelecionarPorCPF(string cpf) => repositorio.SelecionarPorCPF(cpf);
    }
}
