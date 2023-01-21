using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Desafio1.Classes
{
    [Table("Enderecos")]
    public class Endereco : EntidadeBase
    {
        public Cliente Cliente { get; set; }
        public int ClienteID { get; set; }

        [Required()]
        public string CEP { get; set; }

        [Required(ErrorMessage = "Logradouro obrigatório")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Numero obrigatório")]
        public string Numero { get; set; }

        public string Complemento { get; set; }

        [Required(ErrorMessage = "Bairro obrigatório")]
        public string Bairro { get; set; }

        public Cidade Cidade { get; set; }
        [Required(ErrorMessage = "Selecione a Cidade")]
        public int CidadeID { get; set; }

        public override void Validar()
        {
            base.Validar();
        }
    }
}
