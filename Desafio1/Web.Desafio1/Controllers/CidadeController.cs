using DataAccess.Desafio1.Generico;
using DomainModel.Desafio1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Desafio1.Controllers
{
    public class CidadeController : Controller
    {
        #region Repositorio
        Repositorio repositorio = new Repositorio();
        #endregion

        public ActionResult List()
        {
            try
            {
                return View(repositorio.Cidade.ObterTodos());
            }
            catch (Exception ex)
            {
                Alerta(ex);
                return View(new List<Cidade>());
            }
        }

        public ActionResult Edit(int id = 0)
        {
            try
            {
                EnInclusao(id);
                return View(CarregarDropEstado(ObterCidade(id)));
            }
            catch (Exception ex)
            {
                Alerta(ex);
                return View(new Cidade());
            }
        }

        [HttpPost]
        public ActionResult Edit(Cidade entidade, int id = 0)
        {
            try
            {
                if (entidade.EstadoID.Equals(0))
                    return View(CarregarDropEstado(entidade));

                Cidade cidade = ObterCidade(id);
                cidade.Nome = entidade.Nome.ToUpper();
                cidade.Estado = repositorio.Estado.ObterPor(entidade.EstadoID);
                cidade.DataCadastro = id.Equals(0) ? DateTime.Now : cidade.DataCadastro;
                cidade.DataAtualizacao = DateTime.Now;
                cidade.Validar();
                repositorio.Cidade.Salvar(cidade);
                repositorio.SaveChanges();

                if (id.Equals(0))
                    return View(LimparTela());

                return RedirectToAction("List");
            }
            catch (Exception ex)
            {
                Alerta(ex);
                return View(CarregarDropEstado(new Cidade()));
            }
        }

        public ActionResult Delete(int id)
        {
            try
            {
                Cidade cidade = ObterCidade(id);
                string nomeCidade = cidade.Nome;
                repositorio.Cidade.Excluir(cidade);
                repositorio.SaveChanges();
                TempData["Alerta"] = $"Cidade: <b>{nomeCidade}</b> foi excluido do sistema!";
                return RedirectToAction("List");
            }
            catch (Exception ex)
            {
                Alerta(ex);
                return RedirectToAction("List");
            }
        }

        public ActionResult ListaCidadesPorIdEstado(int estadoID)
        {
            return Json(repositorio.Cidade.ObterCidadePorEstadoID(estadoID), JsonRequestBehavior.AllowGet);
        }

        #region Metodos Privados
        private Cidade CarregarDropEstado(Cidade cidade)
        {
            ViewBag.EstadoID = new SelectList
                (
                    repositorio.Estado.ObterTodos(),
                    "ID",
                    "Nome",
                    cidade.EstadoID
                );
            return cidade;
        }

        private Cidade ObterCidade(int id)
        {
            return id.Equals(0) ? new Cidade() : repositorio.Cidade.ObterPor(id);
        }

        private Cidade LimparTela()
        {
            TempData["Mensagem"] = "Sucesso";
            ModelState.Clear();
            EnInclusao(0);
            return CarregarDropEstado(new Cidade());
        }

        private void EnInclusao(int id)
        {
            TempData["EnInclusao"] = id.Equals(0) ? "Cadastro Cidade" : "Edição Cidade";
        }

        private void Alerta(Exception ex)
        {
            TempData["Alerta"] = ex.Message.Replace(Environment.NewLine, "</br>");
        }
        #endregion

    }
}