using DataAccess.Desafio1.Generico;
using DomainModel.Desafio1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Desafio1.Controllers
{
    public class EstadoController : Controller
    {
        #region Repositorio
        Repositorio repositorio = new Repositorio();
        #endregion

        public ActionResult List()
        {
            try
            {
                return View(repositorio.Estado.ObterTodos());
            }
            catch (Exception ex)
            {
                Alerta(ex);
                return View(new List<Estado>());
            }
        }

        public ActionResult Edit(int id = 0)
        {
            Estado estado = new Estado();
            try
            {
                EnInclucao(id);
                return View(ObterEstado(id));
            }
            catch (Exception ex)
            {
                Alerta(ex);
                return View(estado);
            }
        }

        [HttpPost]
        public ActionResult Edit(Estado entidade, int id = 0)
        {
            try
            {
                Estado estado = ObterEstado(id);
                estado.Nome = entidade.Nome == null ? string.Empty : entidade.Nome.ToUpper();
                estado.UF = entidade.UF == null ? string.Empty : entidade.UF.ToUpper();
                estado.DataCadastro = id.Equals(0) ? DateTime.Now : estado.DataCadastro;
                estado.DataAtualizacao = DateTime.Now;
                estado.Validar();
                repositorio.Estado.Salvar(estado);
                repositorio.SaveChanges();

                if (id.Equals(0))
                    return View(LimparTela());

                return RedirectToAction("List");
            }
            catch (Exception ex)
            {
                Alerta(ex);
                return View(new Estado());
            }
        }

        public ActionResult Delete(int id)
        {
            try
            {
                Estado estado = ObterEstado(id);
                string nomeEstado = estado.Nome;
                repositorio.Estado.Excluir(estado);
                repositorio.SaveChanges();
                TempData["Alerta"] = $"Estado: <b>{nomeEstado}</b> foi excluido do sistma";
                return RedirectToAction("List");
            }
            catch (Exception ex)
            {
                Alerta(ex);
                return RedirectToAction("List");
            }
        }

        public ActionResult ObterEstadoPorUF(string uf)
        {
            return Json(repositorio.Estado.ObterEstadoPorUF(uf), JsonRequestBehavior.AllowGet);
        }

        #region Métodos Privados
        private void Alerta(Exception ex)
        {
            TempData["Alerta"] = ex.Message.Replace(Environment.NewLine, "</br>");
        }

        private void EnInclucao(int id)
        {
            TempData["EnInclusao"] = id.Equals(0) ? "Cadastro Estado" : "Edição Estado";
        }

        private Estado ObterEstado(int id)
        {
            return id.Equals(0) ? new Estado() : repositorio.Estado.ObterPor(id);
        }

        private Estado LimparTela()
        {
            TempData["Mensagem"] = "Sucesso";
            ModelState.Clear();
            EnInclucao(0);
            return new Estado();
        }
        #endregion
    }
}