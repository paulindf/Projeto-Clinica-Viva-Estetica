using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaEstetica.Domain.Entidades
{
    public class TipoDocumento
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public Boolean Ativado { get; set; }

        public DateTime DataRegistro { get; set; }
    }
}
