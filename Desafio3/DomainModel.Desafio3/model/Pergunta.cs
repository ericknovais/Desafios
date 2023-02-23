using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3.DomainModel.model
{
    [Table("Perguntas")]
    public class Pergunta : EntityBase
    {
        [Required(ErrorMessage = "A descrição é obrigatório")]
        public string Descricao { get; set; }

        public override void Validar()
        {
            base.Validar();
        }
    }
}
