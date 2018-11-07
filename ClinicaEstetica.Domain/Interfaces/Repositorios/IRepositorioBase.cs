using System.Collections.Generic;

namespace ClinicaEstetica.Domain.Interfaces.Repositorios
{
    /*CRUD PADRÃO*/
    public interface IRepositorioBase<TEntidade> where TEntidade : class
    {
        void Adicionar(TEntidade objeto);

        TEntidade SelecionarPorId(int id);

        IEnumerable<TEntidade> SelecionarTodos();

        IEnumerable<TEntidade> SelecionarTodosNoTracking();

        void Atualizar(TEntidade objeto);

        void Remover(TEntidade objeto);
    }
}
