using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicaEstetica.MVC.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(50, ErrorMessage = "Máximo de {1} caracteres")]
        [MinLength(5, ErrorMessage = "Mínimo de {1} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(50, ErrorMessage = "Máximo de {1} caracteres")]
        [MinLength(5, ErrorMessage = "Mínimo de {1} caracteres")]
        public string Sobrenome { get; set; }

        public virtual TipoDocumentoViewModel TipoDocumento { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(50, ErrorMessage = "Máximo de {1} caracteres")]
        [MinLength(5, ErrorMessage = "Mínimo de {1} caracteres")]
        public string Documento { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(50, ErrorMessage = "Máximo de {1} caracteres")]
        [MinLength(5, ErrorMessage = "Mínimo de {1} caracteres")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(50, ErrorMessage = "Máximo de {1} caracteres")]
        [MinLength(5, ErrorMessage = "Mínimo de {1} caracteres")]
        [DisplayName("Endereço")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(150, ErrorMessage = "Máximo de {1} caracteres")]
        [MinLength(5, ErrorMessage = "Mínimo de {1} caracteres")]
        [EmailAddress(ErrorMessage = "Informe um e-mail válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(20, ErrorMessage = "Máximo de {1} caracteres")]
        [MinLength(8, ErrorMessage = "Mínimo de {1} caracteres")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Senha")]
        [DisplayName("Confirme sua senha")]
        [NotMapped]
        public string ConfirmarSenha { get; set; }

        public virtual IEnumerable<AgendaViewModel> Agendas { get; set; }

        [ScaffoldColumn(false)]
        public Boolean Ativado { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataRegistro { get; set; }
    }
}