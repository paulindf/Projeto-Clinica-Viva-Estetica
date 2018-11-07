using System;
using System.ComponentModel.DataAnnotations;

namespace ClinicaEstetica.MVC.ViewModels
{
    public class AgendaViewModel
    {
        [Key]
        public int Id { get; set; }

        public int ServicoId { get; set; }

        public virtual ServicoViewModel Servico { get; set; }

        public int ClienteId { get; set; }

        public virtual ClienteViewModel Cliente { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public DateTime Horario { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public int Duracao { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data inválida")]
        public DateTime DataCancelamento { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataRegistro { get; set; }
    }
}