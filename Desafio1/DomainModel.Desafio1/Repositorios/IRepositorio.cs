using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Desafio1.Repositorios
{
    public interface IRepositorio
    {
        ICidadeRepositorio Cidade { get; }
        IClienteRepositorio Cliente { get; }
        IEstadoRepositorio Estado { get; }
        IEnderecoRepositorio Endereco { get; }  
        void SaveChanges();
    }
}
