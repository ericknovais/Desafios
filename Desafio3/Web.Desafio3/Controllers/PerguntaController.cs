using Desafio3.AppWeb.ViewModels;
using Desafio3.DataAccess.generic;
using Desafio3.DomainModel.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Desafio3.AppWeb.Controllers
{
    public class PerguntaController : Controller
    {
        Repository repository = new Repository();

        // GET: Pergunta
        public ActionResult List()
        {
            try
            {
                return View(repository.Pergunta.ObterTodos());
            }
            catch (Exception ex)
            {
                Alerta(ex);
                return View(new List<Pergunta>());
            }
        }

        public ActionResult Edit(int id = 0)
        {
            try
            {
                EnInclusao(id);
                return View(ObterPerguntaRespostaViewModel(id));
            }
            catch (Exception ex)
            {
                Alerta(ex);
                return View(new PerguntaRespostaViewModel());
            }
        }

        [HttpPost]
        public ActionResult Edit(PerguntaRespostaViewModel model, int id = 0)
        {
            try
            {
                //model.Respostas.Where(x => x.Descricao == null).Count() > 0
                if (!ModelState.IsValid)
                    return View(model);

                if (model.Respostas.Where(x => x.Correto == true).Count() == 0)
                    throw new Exception($"Selecione uma resposta como a correta!");

                Pergunta pergunta = ObterPergunta(id);
                pergunta.Descricao = model.Pergunta;
                pergunta.DataCriacao = id.Equals(0) ? DateTime.Now : pergunta.DataCriacao;
                pergunta.DataAtualizacao = DateTime.Now;
                pergunta.Validar();
                repository.Pergunta.Salvar(pergunta);

                int contador = 1;
                foreach (var item in model.Respostas)
                {
                    Resposta resposta = ObterResposta(item.ID);
                    resposta.Pergunta = pergunta;
                    resposta.Descricao = item.Descricao;
                    resposta.Correto = item.Correto;
                    resposta.Ordem = contador;
                    resposta.DataCriacao = id.Equals(0) ? DateTime.Now : pergunta.DataCriacao;
                    resposta.DataAtualizacao = DateTime.Now;
                    resposta.Validar();
                    repository.Resposta.Salvar(resposta);
                    contador++;
                }

                repository.SaveChanges();

                if (id.Equals(0))
                    return View(LimparTela());

                return RedirectToAction("List");
            }
            catch (Exception ex)
            {
                Alerta(ex);
                return View(model);
            }
        }

        public ActionResult Delete(int id)
        {
            try
            {
                Pergunta pergunta = ObterPergunta(id);
                repository.Pergunta.Excluir(pergunta);
                repository.SaveChanges();
                TempData["Alerta"] = $"Pergunta: <b>{pergunta.Descricao}</b> foi excluido do sistema!";
                return RedirectToAction("List");
            }
            catch (Exception ex)
            {
                Alerta(ex);
                return RedirectToAction("List");
            }
        }

        public ActionResult Quiz()
        {
            try
            {
                var rnd = new Random();
                PerguntaRespostaViewModel lista = new PerguntaRespostaViewModel()
                {
                    Perguntas = repository.Pergunta.ObterTodos().OrderBy(x => rnd.Next()).ToList(),
                    Respostas = repository.Resposta.ObterTodos().OrderBy(x => x.Ordem = rnd.Next()).ToList()
                };
                return View(lista);
            }
            catch (Exception ex)
            {
                Alerta(ex);
                return View(new PerguntaRespostaViewModel());
            }
        }

        [HttpPost]
        public ActionResult Quiz(PerguntaRespostaViewModel model)
        {
            try
            {
                int qtdRespondidas = model.Respostas.Where(x => x.Correto == true).Count();
                if (!model.LimitePergunta.Equals(qtdRespondidas))
                {
                    model.LimpaRadio = false;
                    throw new Exception($"Faltou responder {(model.LimitePergunta - qtdRespondidas)} perguntas!");
                }


                ResultadoQuizViewModel resultadoQuiz = new ResultadoQuizViewModel();
                resultadoQuiz.QtdPerguntas = model.LimitePergunta;

                foreach (var item in model.Respostas)
                {
                    if (item.Correto)
                        if (item.Correto == repository.Resposta.ObterPor(item.ID).Correto)
                            resultadoQuiz.Acerto++;
                }

                return RedirectToAction("ResultadoQuiz", resultadoQuiz);
            }
            catch (Exception ex)
            {
                Alerta(ex);
                return View(model);
            }
        }

        public ActionResult ResultadoQuiz(ResultadoQuizViewModel model)
        {
            //@TempData["Resultado"] = $"Você acertou";
            return View(model);
        }

        #region Métodos Privados
        private void EnInclusao(int id)
        {
            TempData["EnInclusao"] = id.Equals(0) ? "Cadastro" : "Edição";
        }

        private void Alerta(Exception ex)
        {
            TempData["Alerta"] = ex.Message.Replace(Environment.NewLine, "</br>");
        }

        private PerguntaRespostaViewModel ObterPerguntaRespostaViewModel(int id)
        {
            if (id.Equals(0))
                return new PerguntaRespostaViewModel();

            Pergunta pergunta = ObterPergunta(id);

            PerguntaRespostaViewModel model = new PerguntaRespostaViewModel()
            {
                Pergunta = pergunta.Descricao,
                Respostas = repository.Resposta.ObterRespostaPorPerguntaId(pergunta.ID)
            };

            return model;
        }

        private Pergunta ObterPergunta(int id)
        {
            return id.Equals(0) ? new Pergunta() : repository.Pergunta.ObterPor(id);
        }

        private Resposta ObterResposta(int id)
        {
            return id.Equals(0) ? new Resposta() : repository.Resposta.ObterPor(id);
        }

        private PerguntaRespostaViewModel LimparTela()
        {
            TempData["Sucesso"] = "Foi incluído uma nova <b>pergunta</b> no sistema";
            ModelState.Clear();
            EnInclusao(0);
            return new PerguntaRespostaViewModel();
        }
        #endregion
    }
}