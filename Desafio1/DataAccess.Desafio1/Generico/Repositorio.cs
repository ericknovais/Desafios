using DataAccess.Desafio1.DB;
using DataAccess.Desafio1.Repositorio;
using DomainModel.Desafio1.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Desafio1.Generico
{
    public class Repositorio : IRepositorio
    {
        ContextoDB ctx;

        public Repositorio()
        {
            ctx = new ContextoDB();
        }

        ICidadeRepositorio cidade;
        public ICidadeRepositorio Cidade { get { return cidade ?? (cidade = new CidadeRepositorio(ctx)); } }

        IClienteRepositorio cliente;
        public IClienteRepositorio Cliente { get { return cliente ?? (cliente = new ClienteRepositorio(ctx)); } }

        IEstadoRepositorio estado;
        public IEstadoRepositorio Estado  { get { return estado ?? (estado = new EstadoRepositorio(ctx)); } }

        IEnderecoRepositorio endereco;
        public IEnderecoRepositorio Endereco { get { return endereco ?? (endereco = new EnderecoRepositorio(ctx)); } }

        public void SaveChanges()
        {
            ctx.SaveChanges();
        }
    }
}
