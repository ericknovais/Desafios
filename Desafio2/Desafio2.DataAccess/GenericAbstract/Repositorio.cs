using Desafio2.DataAccess.DB;
using Desafio2.DataAccess.Repository;
using Desafio2.DomainModel.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2.DataAccess.GenericAbstract
{
    public class Repositorio : IRepositorio
    {
        ContextoDB ctx;

        public Repositorio()
        {
            ctx = new ContextoDB();
        }

        IUsuarioRepositorio usuario;
        public IUsuarioRepositorio Usuario { get { return usuario ?? (usuario = new UsuaioRepositorio(ctx)); } }

        public void SaveChanges()
        {
            ctx.SaveChanges();
        }
    }
}
