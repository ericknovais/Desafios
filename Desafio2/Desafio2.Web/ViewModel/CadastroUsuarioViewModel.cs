using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Desafio2.Web.ViewModel
{
    public class CadastroUsuarioViewModel
    {
        [Required(ErrorMessage = "Usuário obrigatório")]
        [Display(Name = "Usuário")]
        public string Login { get; set; }

        [Required(ErrorMessage = "E-mail obrigatório")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "A senha deve ter pelo menos 6 caracteres")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Confirme a senha")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirme senha")]
        [Compare(nameof(Senha), ErrorMessage = "As senhas não são iguais")]
        public string ConfirmacaoSenha { get; set; }

    }
}