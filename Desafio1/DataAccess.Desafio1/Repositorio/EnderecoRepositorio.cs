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
    class EnderecoRepositorio : AbstractRepositorio<Endereco>, IEnderecoRepositorio
    {
        ContextoDB ctx = new ContextoDB();

        public EnderecoRepositorio(ContextoDB contexto) : base(contexto)
        {
            ctx = contexto;
        }

        public Endereco ObterEnderecoPorClienteID(int clienteid)
        {
            return ctx.Enderecos.FirstOrDefault(x => x.ClienteID == clienteid);
        }
    }
}
