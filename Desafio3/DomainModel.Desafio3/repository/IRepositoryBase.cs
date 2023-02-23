using Desafio3.DomainModel.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3.DomainModel.repository
{
   public interface IRepositoryBase<T> where T : EntityBase
    {
        void Salvar(T entidade);
        void Excluir(T entidade);
        T ObterPor(int id);
        IList<T> ObterTodos();
    }
}
