using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Desafio1.Classes
{
    [Table("Cidades")]
    public class Cidade : EntidadeBase
    {
        [Required(ErrorMessage = "Nome obrigatório")]
        public string Nome { get; set; }
        public Estado Estado { get; set; }
        [Required(ErrorMessage = "Selecione o Estado")]
        public int EstadoID { get; set; }

        public override void Validar()
        {
            base.Validar();
        }
    }
}
