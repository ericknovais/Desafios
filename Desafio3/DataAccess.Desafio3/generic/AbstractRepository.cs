using Desafio3.DataAccess.db;
using Desafio3.DomainModel.model;
using Desafio3.DomainModel.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3.DataAccess.generic
{
    abstract class AbstractRepository<T> : IRepositoryBase<T> where T : EntityBase
    {
        ContextDataBase ctx;

        public AbstractRepository(ContextDataBase context)
        {
            ctx = context;
        }

        public void Excluir(T entidade)
        {
            ctx.Set<T>().Remove(entidade);
        }

        public T ObterPor(int id)
        {
            return ctx.Set<T>().FirstOrDefault(x => x.ID.Equals(id));
        }

        public IList<T> ObterTodos()
        {
            return ctx.Set<T>().ToList();
        }

        public void Salvar(T entidade)
        {
            if (entidade.ID.Equals(0))
                ctx.Set<T>().Add(entidade);
        }
    }
}
