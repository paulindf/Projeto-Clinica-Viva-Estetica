using ClinicaEstetica.Domain.Entidades;
using ClinicaEstetica.Domain.Interfaces.Repositorios;
using ClinicaEstetica.Domain.Interfaces.Servicos;

namespace ClinicaEstetica.Domain.Servicos
{
    public class TipoServicoService : ServiceBase<TipoServico>, ITipoServicoService
    {
        private readonly ITipoServicoRepositorio repositorio;

        public TipoServicoService(ITipoServicoRepositorio repositorio)
            : base(repositorio) => this.repositorio = repositorio;
    }
}
