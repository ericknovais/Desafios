using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Desafio1.Classes
{
    [Table("Clientes")]
    public class Cliente : EntidadeBase
    {
        #region Propiedades

        public string NomeCompleto { get; set; }

        public DateTime DataNascimento { get; set; }

        public string CPF { get; set; }

        public string Email { get; set; }
        #endregion

        #region Mensagens de Erros
        //[NotMapped]
        private string _msgEmail = "E-mail com formato invalido";

        [NotMapped]
        private string _msgDataNascimento = "Data de Nascimento não pode ser maior que Hoje";
        #endregion

        #region Validações
        public override void Validar()
        {
            ValidarEmail();
            ValidadeDataNascimento();
            base.Validar();
        }

        private void ValidadeDataNascimento()
        {
            if (DataNascimento > DateTime.Today)
                _msgErro.Append($"{_msgDataNascimento} {Environment.NewLine}");
        }

        private void ValidarEmail()
        {
            if (!Email.Contains("@") || !Email.Contains(".com"))
                _msgErro.Append($"{_msgEmail} {Environment.NewLine}");
        }
        #endregion
    }
}
