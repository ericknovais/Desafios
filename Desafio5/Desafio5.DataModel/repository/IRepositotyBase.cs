using Desafio5.DataModel.model;
using System.Collections.Generic;

namespace Desafio5.DataModel.repository
{
    public interface IRepositotyBase<T> where T : EntityBase
    {
        void Salvar(T entidade);
        void Excluir(T entidade);
        T ObterPor(int id);
        IList<T> ObterTodos();
    }
}
