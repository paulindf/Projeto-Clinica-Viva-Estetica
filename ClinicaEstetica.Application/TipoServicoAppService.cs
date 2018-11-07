using ClinicaEstetica.Application.Interface;
using ClinicaEstetica.Domain.Entidades;
using ClinicaEstetica.Domain.Interfaces.Servicos;

namespace ClinicaEstetica.Application
{
    public class TipoServicoAppService : AppServiceBase<TipoServico>, ITipoServicoAppService
    {
        private readonly ITipoServicoService servico;

        public TipoServicoAppService(ITipoServicoService servico)
            : base(servico) => this.servico = servico;
    }
}
