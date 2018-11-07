﻿using ClinicaEstetica.Domain.Entidades;

namespace ClinicaEstetica.Domain.Interfaces.Repositorios
{
    /*aqui devo colocar os contratos específicos*/
    public interface IClienteRepositorio : IRepositorioBase<Cliente>
    {
        Cliente SelecionarPorCPF(string cpf);
    }
}
