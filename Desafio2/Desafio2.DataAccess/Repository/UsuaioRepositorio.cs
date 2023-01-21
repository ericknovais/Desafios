using Desafio2.DataAccess.DB;
using Desafio2.DataAccess.GenericAbstract;
using Desafio2.DomainModel.Class;
using Desafio2.DomainModel.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2.DataAccess.Repository
{
    class UsuaioRepositorio : AbstractRepositorio<Usuario>, IUsuarioRepositorio
    {
        ContextoDB ctx = new ContextoDB();

        public UsuaioRepositorio(ContextoDB contextoDB) : base(contextoDB)
        {
            ctx = contextoDB;
        }

        public IList<Usuario> UsuarioExiste(string login, string senha)
        {
            if (senha.Equals(string.Empty))
            {
                if (login.Contains("@") || login.Contains(".com"))
                    return ctx.Usuarios.Where(x => x.Email == login).ToList();

                return ctx.Usuarios.Where(x => x.Login == login).ToList();
            }

            if (login.Contains("@") || login.Contains(".com"))
                return ctx.Usuarios.Where(x => x.Email == login && x.Senha == senha).ToList();

            return ctx.Usuarios.Where(x => x.Login == login && x.Senha == senha).ToList();
        }
    }
}
