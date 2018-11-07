using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaEstetica.Domain.Entidades
{
    public class TipoServico
    {
        public int Id { get; set; }

        public String Descricao { get; set; }

        public bool Ativado { get; set; }

        public DateTime DataRegistro { get; set; }
    }
}
