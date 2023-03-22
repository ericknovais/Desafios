using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2.DomainModel.Class
{
    [Table("Usuaios")]
    public class Usuario : EntidadeBase
    {
        public string Login { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }
        
        public bool Ativo { get; set; }

        private string _msgEmail = "Email esta em um formato invalido";

        public override void Validar()
        {
            ValidarEmail();
            base.Validar();
        }

        private void ValidarEmail() 
        {
            if (!Email.Contains("@") || !Email.Contains(".com"))
                _msgErro.Append($"{_msgEmail} {Environment.NewLine}");
        }
    }
}
