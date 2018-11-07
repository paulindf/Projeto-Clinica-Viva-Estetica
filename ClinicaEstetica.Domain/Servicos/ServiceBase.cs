using ClinicaEstetica.Domain.Interfaces.Repositorios;
using ClinicaEstetica.Domain.Interfaces.Servicos;
using System;
using System.Collections.Generic;

namespace ClinicaEstetica.Domain.Servicos
{
    public class ServiceBase<TEntidade> : IDisposable, IServiceBase<TEntidade> where TEntidade : class
    {
        private readonly IRepositorioBase<TEntidade> repositorio;

        public ServiceBase(IRepositorioBase<TEntidade> repositorio) => this.repositorio = repositorio;

        public void Adicionar(TEntidade objeto) => repositorio.Adicionar(objeto);

        public void Atualizar(TEntidade objeto) => repositorio.Atualizar(objeto);

        public void Remover(TEntidade objeto) => repositorio.Remover(objeto);

        public TEntidade SelecionarPorId(int id) => repositorio.SelecionarPorId(id);

        public IEnumerable<TEntidade> SelecionarTodos() => repositorio.SelecionarTodos();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}
