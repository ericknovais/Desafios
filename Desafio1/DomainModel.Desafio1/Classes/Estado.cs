using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Desafio1.Classes
{
    [Table("Estados")]
    public class Estado : EntidadeBase
    {
        #region Propriedades
        [Required(ErrorMessage = "Nome obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "UF obrigatório")]
        public string UF { get; set; }
        #endregion

        #region Mensagens de Erros
        [NotMapped]
        private string MsgUF { get; } = "O Campo UF deve conter 2 caracteres";
        #endregion

        #region Metodos Validações
        public override void Validar()
        {
            ValidarUF();
            base.Validar();
        }

        private void ValidarUF()
        {
            if (!UF.Length.Equals(2))
                _msgErro.Append($"{MsgUF} {Environment.NewLine}");
        }
        #endregion
    }
}
