using Desafio5.DataModel.model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Desafio5.DataModel.model
{
    [Table("Enderecos")]
    public class Endereco : EntityBase
    {
        [Required(ErrorMessage = "CEP obrigatório")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "Logradouro obrigatório")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Numero obrigatório")]
        public string Numero { get; set; }

        public string Complemento { get; set; }

        [Required(ErrorMessage = "Bairro obrigatório")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Estado obrigatório")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Cidade obrigatório")]
        public string Cidade { get; set; }

    }
}
