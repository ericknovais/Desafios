using DataAccess.Desafio1.DB;
using DomainModel.Desafio1.Classes;
using DomainModel.Desafio1.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Desafio1.Generico
{
    abstract class AbstractRepositorio<T> : IRepositorioBase<T> where T : EntidadeBase
    {
        #region Contexto DB
        ContextoDB ctx;
        #endregion

        public AbstractRepositorio(ContextoDB contexto)
        {
            ctx = contexto;
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