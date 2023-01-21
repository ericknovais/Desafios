using DomainModel.Desafio1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Desafio1.Repositorios
{
    public interface IRepositorioBase<T> where T : EntidadeBase
    {
        void Salvar(T entidade);
        void Excluir(T entidade);
        T ObterPor(int id);
        IList<T> ObterTodos();
    }
}
