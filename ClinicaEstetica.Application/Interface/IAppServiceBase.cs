using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaEstetica.Application.Interface
{
    public interface IAppServiceBase<TEntidade> where TEntidade : class
    {
        void Adicionar(TEntidade objeto);

        TEntidade SelecionarPorId(int id);

        IEnumerable<TEntidade> SelecionarTodos();

        void Atualizar(TEntidade objeto);

        void Remover(TEntidade objeto);
    }
}
