using System;
using System.Collections.Generic;

namespace ClinicaEstetica.Domain.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }
        
        public virtual TipoDocumento TipoDocumento { get; set; }

        public string Documento { get; set; }

        public string Celular { get; set; }

        public string Endereco { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public virtual IEnumerable<Agenda> Agendas { get; set; }

        public Boolean Ativado { get; set; }

        public DateTime DataRegistro { get; set; }
    }
}
