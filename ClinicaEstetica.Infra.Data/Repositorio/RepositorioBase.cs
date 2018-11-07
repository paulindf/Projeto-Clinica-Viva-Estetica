using ClinicaEstetica.Domain.Interfaces.Repositorios;
using ClinicaEstetica.Infra.Data.Contexto;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ClinicaEstetica.Infra.Data.Repositorio
{
    public class RepositorioBase<TEntidade> : IRepositorioBase<TEntidade> where TEntidade : class
    {
        private readonly ProjetoContexto contexto;

        public RepositorioBase(ProjetoContexto db) => this.contexto = db;

        public void Adicionar(TEntidade objeto)
        {
            contexto.Set<TEntidade>().Add(objeto);
            contexto.SaveChanges();
        }

        public void Atualizar(TEntidade objeto)
        {
            contexto.Entry(objeto).State = EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Remover(TEntidade objeto)
        {
            contexto.Set<TEntidade>().Remove(objeto);
            contexto.SaveChanges();
        }

        public TEntidade SelecionarPorId(int id) => contexto.Set<TEntidade>().Find(id);

        public IEnumerable<TEntidade> SelecionarTodosNoTracking() => contexto.Set<TEntidade>().AsNoTracking().ToList();

        public IEnumerable<TEntidade> SelecionarTodos() => contexto.Set<TEntidade>().ToList();
    }
}