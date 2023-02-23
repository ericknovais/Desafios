using Desafio3.DomainModel.model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Desafio3.AppWeb.ViewModels
{
    public class PerguntaRespostaViewModel
    {

        [Required(ErrorMessage = "Descrição da pergunta obrigatório")]
        public string Pergunta { get; set; }
        public List<Pergunta> Perguntas { get; set; }
        public List<Resposta> Respostas { get; set; }
        public int LimitePergunta { get; set; } = 10;
        public int LimiteResposta { get; set; } = 5;
        public int MinimoResposta { get; set; } = 2;
        public bool LimpaRadio { get; set; } = true;
    }
}