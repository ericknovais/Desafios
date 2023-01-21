using Desafio2.DomainModel.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2.DomainModel.Repository
{
    public interface IRepositorioBase<T> where T: EntidadeBase
    {
        void Salvar(T entidade);
        void Excluir(T entidade);
        T ObterPor(int id);
        IList<T> ObterTodos();
    }
}
