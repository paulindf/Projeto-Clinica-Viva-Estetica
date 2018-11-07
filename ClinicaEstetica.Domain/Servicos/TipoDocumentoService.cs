using ClinicaEstetica.Domain.Entidades;
using ClinicaEstetica.Domain.Interfaces.Repositorios;
using ClinicaEstetica.Domain.Interfaces.Servicos;

namespace ClinicaEstetica.Domain.Servicos
{
    public class TipoDocumentoService : ServiceBase<TipoDocumento>, ITipoDocumentoService
    {
        private readonly ITipoDocumentoRepositorio repositorio;

        public TipoDocumentoService(ITipoDocumentoRepositorio repositorio)
            : base(repositorio) => this.repositorio = repositorio;
    }
}
