using ClinicaEstetica.Application.Interface;
using ClinicaEstetica.Domain.Entidades;
using ClinicaEstetica.Domain.Interfaces.Servicos;

namespace ClinicaEstetica.Application
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService servico;

        public ClienteAppService(IClienteService servico)
            : base(servico) => this.servico = servico;
    }
}
