using ClinicaEstetica.Domain.Entidades;
using ClinicaEstetica.Domain.Interfaces.Repositorios;
using ClinicaEstetica.Infra.Data.Contexto;

namespace ClinicaEstetica.Infra.Data.Repositorio
{
    public class TipoDocumentoRepositorio : RepositorioBase<TipoDocumento>, ITipoDocumentoRepositorio
    {
        private readonly ProjetoContexto contexto;

        /*detalhar buscas específicas / especializadas*/
        public TipoDocumentoRepositorio(ProjetoContexto contexto) : base(contexto) => this.contexto = contexto;
    }
}
