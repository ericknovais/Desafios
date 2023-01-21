using DomainModel.Desafio1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Desafio1.Repositorios
{
    public interface IClienteRepositorio : IRepositorioBase<Cliente>
    {
        IList<Cliente> ObterClientePorCPF(string cpf);
    }
}
