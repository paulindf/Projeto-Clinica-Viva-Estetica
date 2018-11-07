using ClinicaEstetica.Domain.Interfaces.Repositorios;
using ClinicaEstetica.Infra.Data.Contexto;
using System;

namespace ClinicaEstetica.Infra.Data.Repositorio
{
    public class UnitOfWork : IDisposable
    {
        private readonly ProjetoContexto contexto = null;
        private bool _disposed = false;

        public UnitOfWork()
        {
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;

            contexto = new ProjetoContexto();

            ClienteRepositorio = new ClienteRepositorio(contexto);
            AgendaRepositorio = new AgendaRepositorio(contexto);
            TipoServicoRepositorio = new TipoServicoRepositorio(contexto);
            TipoDocumentoRepositorio = new TipoDocumentoRepositorio(contexto);
        }
        
        public UnitOfWork(ProjetoContexto contexto) => this.contexto = contexto;

        public UnitOfWork(IClienteRepositorio repositorio) => ClienteRepositorio = repositorio;

        public UnitOfWork(IAgendaRepositorio repositorio) => AgendaRepositorio = repositorio;

        public UnitOfWork(ITipoServicoRepositorio repositorio) => TipoServicoRepositorio = repositorio;

        public UnitOfWork(ITipoDocumentoRepositorio repositorio) => TipoDocumentoRepositorio = repositorio;

        public IClienteRepositorio ClienteRepositorio { get; private set; }

        public IAgendaRepositorio AgendaRepositorio { get; private set; }

        public ITipoDocumentoRepositorio TipoDocumentoRepositorio { get; private set; }

        public ITipoServicoRepositorio TipoServicoRepositorio { get; private set; }

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
            throw new NotImplementedException();
        }

        protected virtual void Dispose(bool dispose)
        {
            if (!_disposed && dispose)
                contexto.Dispose();

            _disposed = true;
        }
    }
}
