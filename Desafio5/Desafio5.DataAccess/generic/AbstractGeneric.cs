using Desafio5.DataAccess.db;
using Desafio5.DataModel.model;
using Desafio5.DataModel.repository;
using System.Collections.Generic;
using System.Linq;

namespace Desafio5.DataAccess.generic
{
    abstract class AbstractGeneric<T> : IRepositotyBase<T> where T : EntityBase
    {
        ContextDataBase ctx;

        public AbstractGeneric(ContextDataBase context)
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
