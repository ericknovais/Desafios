using DomainModel.Desafio1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Desafio1.Repositorios
{
    public interface IEnderecoRepositorio : IRepositorioBase<Endereco>
    {
        Endereco ObterEnderecoPorClienteID(int clienteid);
    }
}
