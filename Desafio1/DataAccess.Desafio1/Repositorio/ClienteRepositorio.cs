using DataAccess.Desafio1.DB;
using DataAccess.Desafio1.Generico;
using DomainModel.Desafio1.Classes;
using DomainModel.Desafio1.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Desafio1.Repositorio
{
    class ClienteRepositorio : AbstractRepositorio<Cliente> , IClienteRepositorio
    {
        ContextoDB ctx = new ContextoDB();

        public ClienteRepositorio(ContextoDB contexto) : base(contexto)
        {
            ctx = contexto;
        }

        public IList<Cliente> ObterClientePorCPF(string cpf)
        {
            return ctx.Clientes.Where(x =>x.CPF == cpf).ToList();
        }
    }
}
