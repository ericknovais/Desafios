using Desafio2.DataAccess.GenericAbstract;
using Desafio2.DomainModel.Class;
using Desafio2.Web.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Desafio2.Web.Controllers
{
    public class UsuarioController : Controller
    {
        Repositorio repositorio = new Repositorio();

        // GET: Usuario
        public ActionResult Cadastro()
        {
            Logout();
            return View(new CadastroUsuarioViewModel());
        }

        [HttpPost]
        public ActionResult Cadastro(CadastroUsuarioViewModel entidade)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(entidade);

                VerificaLoginEEmail(entidade);

                Usuario usuario = new Usuario()
                {
                    Login = entidade.Login.ToLower(),
                    Email = entidade.Email.ToLower(),
                    Senha = entidade.Senha,
                    DataCadastro = DateTime.Now,
                    DataAtualizacao = DateTime.Now
                };
                usuario.Validar();
                repositorio.Usuario.Salvar(usuario);
                repositorio.SaveChanges();

                return RedirectToAction("Login");
            }
            catch (Exception ex)
            {
                Alerta(ex);
                return View(entidade);
            }
        }

        public ActionResult Login()
        {
            Logout();
            return View(new LoginViewModel());
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel entidade)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(entidade);

                var usuario = repositorio.Usuario.UsuarioExiste(entidade.Login.ToLower(), entidade.Senha);
                if (usuario.Count.Equals(0))
                {
                    ModelState.AddModelError("Login", "Usuário ou Senha Invalido!");
                    return View(entidade);
                }

                ClaimsIdentity identity = new ClaimsIdentity(new[]
                    {
                        new Claim(ClaimTypes.Name, usuario[0].Login),
                        new Claim("Login", usuario[0].Login),
                    }, "ApplicationCookie");

                Request.GetOwinContext().Authentication.SignIn(identity);

                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                Alerta(ex);
                return View(entidade);
            }
        }

        #region Métodos Privados
        private void Alerta(Exception ex)
        {
            TempData["Alerta"] = ex.Message.Replace(Environment.NewLine, "</br>");
        }

        private void Logout()
        {
            Request.GetOwinContext().Authentication.SignOut("ApplicationCookie");
        }

        private void VerificaLoginEEmail(CadastroUsuarioViewModel entidade)
        {
            StringBuilder _msg = new StringBuilder();
            if (repositorio.Usuario.UsuarioExiste(entidade.Login.ToLower()).Count > 0)
                _msg.Append($"O usuario <b>{entidade.Login}</b> já esta sendo usado no sistema!" + Environment.NewLine);

            if (repositorio.Usuario.UsuarioExiste(entidade.Email.ToLower()).Count > 0)
                _msg.Append($"O e-mail <b>{entidade.Email}</b> já esta sendo usado no sistema!" + Environment.NewLine);

            if (_msg.Length > 0)
                throw new Exception(_msg.ToString());
        }

        #endregion
    }
}