using Desafio2.DataAccess.DB;
using Desafio2.DomainModel.Class;
using Desafio2.DomainModel.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2.DataAccess.GenericAbstract
{
    abstract class AbstractRepositorio<T> : IRepositorioBase<T> where T : EntidadeBase
    {
        #region contextoDB
        ContextoDB ctx;
        #endregion

        public AbstractRepositorio(ContextoDB contextoDB)
        {
            ctx = contextoDB;
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
