using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web.Desafio1.ViewModels
{
    public class ClienteViewModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Nome obrigatório")]
        public string NomeCompleto { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Informe a data de nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "CPF obrigatório")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Email obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "CEP obrigatório")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "Logradouro obrigatório")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Numero obrigatório")]
        public string Numero { get; set; }

        public string Complemento { get; set; }

        [Required(ErrorMessage = "Bairro obrigatório")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Selecione o Estado")]
        public int EstadoID { get; set; }

        [Required(ErrorMessage = "Selecione a Cidade")]
        public int CidadeID { get; set; }
    }
}