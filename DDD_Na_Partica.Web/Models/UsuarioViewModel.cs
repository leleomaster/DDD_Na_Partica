using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DDD_Na_Partica.Web.Models
{
    public class UsuarioViewModel
    {
        public int Id { get; set; }

        public int IdPessoa { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Nome")]
        [MaxLength(150, ErrorMessage = "Campo com tamanho máximo de 150 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Login")]
        [MaxLength(20, ErrorMessage = "Campo com tamanho máximo de 20 caracteres")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Senha")]
        [MaxLength(30, ErrorMessage = "Campo com tamanho máximo de 30 caracteres")]
        public string Senha { get; set; }

        [Display(Name = "Ativo")]
        public bool Ativo { get; set; }

        public string Permissao { get; set; }
    }
}