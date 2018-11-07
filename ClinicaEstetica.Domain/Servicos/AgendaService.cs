using ClinicaEstetica.Domain.Entidades;
using ClinicaEstetica.Domain.Interfaces.Repositorios;
using ClinicaEstetica.Domain.Interfaces.Servicos;

namespace ClinicaEstetica.Domain.Servicos
{
    public class AgendaService : ServiceBase<Agenda>, IAgendaService
    {
        private readonly IAgendaRepositorio repositorio;

        public AgendaService(IAgendaRepositorio repositorio)
            : base(repositorio) => this.repositorio = repositorio;
    }
}
