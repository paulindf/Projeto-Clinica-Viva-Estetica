using System.Collections.Generic;

namespace ClinicaEstetica.Domain.Interfaces.Servicos
{
    public interface IServiceBase<TEntidade> where TEntidade : class
    {
        void Adicionar(TEntidade objeto);

        TEntidade SelecionarPorId(int id);

        IEnumerable<TEntidade> SelecionarTodos();

        void Atualizar(TEntidade objeto);

        void Remover(TEntidade objeto);
    }
}
