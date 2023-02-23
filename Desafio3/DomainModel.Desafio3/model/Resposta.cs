using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3.DomainModel.model
{
    [Table("Respostas")]
    public class Resposta : EntityBase
    {
        public Pergunta Pergunta { get; set; }
        public int PerguntaID { get; set; }
        
        [Required(ErrorMessage = "Descrição da resposta obrigatório")]
        public string Descricao { get; set; }
        public bool Correto { get; set; }
        public int Ordem { get; set; }
        
        public override void Validar()
        {
            base.Validar();
        }
    }
}
