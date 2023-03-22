using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2.DomainModel.Class
{
    [Table("Usuarios")]
    public class Usuario : EntidadeBase
    {
        [Required]
        [Display(Name ="Usuário")]
        public string Login { get; set; }

        [Required]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        [Required]
        public string Senha { get; set; }
        
        public bool Ativo { get; set; }

        private string _msgEmail = "Email esta em um formato invalido";

        public override void Validar()
        {
            ValidarEmail();
            ValidarCampoTexto(Login);
            ValidarCampoTexto(Senha);
            base.Validar();
        }

        private void ValidarEmail() 
        {
            if (!Email.Contains("@") || !Email.Contains(".com"))
                _msgErro.Append($"{_msgEmail} {Environment.NewLine}");
        }
    }
}
