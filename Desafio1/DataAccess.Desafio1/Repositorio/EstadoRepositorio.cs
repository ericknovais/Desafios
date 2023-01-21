using DataAccess.Desafio1.DB;
using DataAccess.Desafio1.Generico;
using DomainModel.Desafio1.Classes;
using DomainModel.Desafio1.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Desafio1.Repositorio
{
    class EstadoRepositorio : AbstractRepositorio<Estado>, IEstadoRepositorio
    {
        ContextoDB ctx = new ContextoDB();
        public EstadoRepositorio(ContextoDB contexto) : base(contexto)
        {
            ctx = contexto;
        }

        public new IList<Estado> ObterTodos()
        {
            return ctx.Estados.OrderBy(x => x.Nome).ToList();
        }

        public Estado ObterEstadoPorUF(string uf)
        {
            return ctx.Estados.FirstOrDefault(x => x.UF == uf);
        }
    }
}
