using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaEstetica.Domain.Entidades
{
    public class Agenda
    {
        public int Id { get; set; }

        public int ServicoId { get; set; }

        public virtual TipoServico Servico { get; set; }

        public int ClienteId { get; set; }

        public virtual Cliente Cliente { get; set; }

        public DateTime Horario { get; set; }

        public int Duracao { get; set; }

        public DateTime DataCancelamento { get; set; }

        public DateTime DataRegistro { get; set; }
    }
}
