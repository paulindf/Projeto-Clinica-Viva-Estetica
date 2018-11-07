using ClinicaEstetica.Domain.Entidades;
using ClinicaEstetica.Domain.Interfaces.Repositorios;
using ClinicaEstetica.Infra.Data.Contexto;

namespace ClinicaEstetica.Infra.Data.Repositorio
{
    public class TipoServicoRepositorio : RepositorioBase<TipoServico>, ITipoServicoRepositorio
    {
        private readonly ProjetoContexto contexto;

        /*detalhar buscas específicas / especializadas*/
        public TipoServicoRepositorio(ProjetoContexto contexto) : base(contexto) => this.contexto = contexto;
    }
}
