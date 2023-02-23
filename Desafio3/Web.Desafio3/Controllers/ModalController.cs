using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Desafio3.AppWeb.Controllers
{
    public class ModalController : Controller
    {
        // GET: Modal
        public ActionResult Sucesso()
        {
            return View();
        }
        public ActionResult Alerta()
        {
            return View();
        }
    }
}