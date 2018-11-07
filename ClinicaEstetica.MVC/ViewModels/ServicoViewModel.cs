using System;
using System.ComponentModel.DataAnnotations;

namespace ClinicaEstetica.MVC.ViewModels
{
    public class ServicoViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo descrição é obrigatório")]
        [MaxLength(80, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(8, ErrorMessage = "Mínimo de {0} caracteres")]
        public String Descricao { get; set; }

        [ScaffoldColumn(false)]
        public bool Ativado { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataRegistro { get; set; }
    }
}