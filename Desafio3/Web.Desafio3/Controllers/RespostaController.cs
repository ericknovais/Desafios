using Desafio3.DataAccess.generic;
using Desafio3.DomainModel.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Desafio3.AppWeb.Controllers
{
    public class RespostaController : Controller
    {
        Repository repository = new Repository();
        // GET: Resposta
        public ActionResult Delete(int id)
        {
            try
            {
                Resposta resposta = repository.Resposta.ObterPor(id);
                repository.Resposta.Excluir(resposta);
                repository.SaveChanges();
                return Json("{Mensagem: foi excluido do sistema a resposta " + resposta.Descricao + "}", JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                 return Json(ex.Message, JsonRequestBehavior.AllowGet);
            }
        }
    }
}