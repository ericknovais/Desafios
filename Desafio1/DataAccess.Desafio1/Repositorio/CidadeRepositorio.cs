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
    class CidadeRepositorio : AbstractRepositorio<Cidade>, ICidadeRepositorio
    {
        ContextoDB ctx = new ContextoDB();

        public CidadeRepositorio(ContextoDB contexto): base(contexto)
        {
            ctx = contexto;
        }

        public IList<Cidade> ObterCidadePorEstadoID(int estadoID)
        {
            return ctx.Cidades.OrderBy(x => x.Nome).Where(x => x.EstadoID == estadoID).ToList();
        }

        public new IList<Cidade> ObterTodos() 
        {
            return ctx.Cidades.Include("Estado").OrderBy(x => x.Estado.Nome).ToList();
        }
    }
}
