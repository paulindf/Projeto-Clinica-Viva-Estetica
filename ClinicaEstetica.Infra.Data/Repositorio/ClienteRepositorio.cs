using ClinicaEstetica.Domain.Entidades;
using ClinicaEstetica.Domain.Interfaces.Repositorios;
using ClinicaEstetica.Infra.Data.Contexto;
using System.Linq;

namespace ClinicaEstetica.Infra.Data.Repositorio
{
    public class ClienteRepositorio : RepositorioBase<Cliente>, IClienteRepositorio
    {
        private readonly ProjetoContexto contexto;

        /*detalhar buscas específicas / especializadas*/
        public ClienteRepositorio(ProjetoContexto contexto) : base(contexto) => this.contexto = contexto;

        public Cliente SelecionarPorCPF(string cpf) => contexto.Clientes.SingleOrDefault(p => p.Documento == cpf);

    }
}
