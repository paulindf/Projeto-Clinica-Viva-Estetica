using System;
using System.ComponentModel.DataAnnotations;

namespace ClinicaEstetica.MVC.ViewModels
{
    public class TipoDocumentoViewModel
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(80, ErrorMessage = "Máxmo de {0} caracteres")]
        [MinLength(8, ErrorMessage = "Mínimo de {0} caracteres")]
        public string Descricao { get; set; }

        [ScaffoldColumn(false)]
        public Boolean Ativado { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataRegistro { get; set; }
    }
}