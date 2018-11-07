using ClinicaEstetica.Application.Interface;
using ClinicaEstetica.Domain.Entidades;
using ClinicaEstetica.Domain.Interfaces.Servicos;

namespace ClinicaEstetica.Application
{
    public class AgendaAppService : AppServiceBase<Agenda>, IAgendaAppService
    {
        private readonly IAgendaService servico;

        public AgendaAppService(IAgendaService servico)
            : base(servico) => this.servico = servico;

    }
}
