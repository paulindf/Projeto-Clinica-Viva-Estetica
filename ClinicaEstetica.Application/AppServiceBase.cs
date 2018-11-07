using ClinicaEstetica.Application.Interface;
using ClinicaEstetica.Domain.Interfaces.Servicos;
using System;
using System.Collections.Generic;

namespace ClinicaEstetica.Application
{
    public class AppServiceBase<TEntidade> : IDisposable, IAppServiceBase<TEntidade> where TEntidade : class
    {
        private readonly IServiceBase<TEntidade> servico;

        public AppServiceBase(IServiceBase<TEntidade> servicebase) => this.servico = servicebase;

        public void Adicionar(TEntidade objeto) => servico.Adicionar(objeto);

        public void Atualizar(TEntidade objeto) => servico.Atualizar(objeto);

        public void Remover(TEntidade objeto) => servico.Remover(objeto);

        public TEntidade SelecionarPorId(int id) => servico.SelecionarPorId(id);

        public IEnumerable<TEntidade> SelecionarTodos() => servico.SelecionarTodos();

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
