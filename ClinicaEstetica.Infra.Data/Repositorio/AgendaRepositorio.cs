using ClinicaEstetica.Domain.Entidades;
using ClinicaEstetica.Domain.Interfaces.Repositorios;
using ClinicaEstetica.Infra.Data.Contexto;

namespace ClinicaEstetica.Infra.Data.Repositorio
{
    public class AgendaRepositorio : RepositorioBase<Agenda>, IAgendaRepositorio
    {
        private readonly ProjetoContexto contexto;

        /*detalhar buscas específicas / especializadas*/
        public AgendaRepositorio(ProjetoContexto contexto) : base(contexto) => this.contexto = contexto;
    }
}
