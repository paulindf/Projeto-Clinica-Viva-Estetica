using ClinicaEstetica.Application.Interface;
using ClinicaEstetica.Domain.Entidades;
using ClinicaEstetica.Domain.Interfaces.Servicos;

namespace ClinicaEstetica.Application
{
    public class TipoDocumentoAppService : AppServiceBase<TipoDocumento>, ITipoDocumentoAppService
    {
        private readonly ITipoDocumentoService servico;

        public TipoDocumentoAppService(ITipoDocumentoService servico)
            : base(servico) => this.servico = servico;
    }
}
