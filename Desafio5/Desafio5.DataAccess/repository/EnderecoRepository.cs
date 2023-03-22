using Desafio5.DataAccess.db;
using Desafio5.DataAccess.generic;
using Desafio5.DataModel.model;
using Desafio5.DataModel.repository;

namespace Desafio5.DataAccess.repository
{
    class EnderecoRepository : AbstractGeneric<Endereco>, IEnderecoRepository
    {
        ContextDataBase ctx;
        public EnderecoRepository(ContextDataBase context) : base(context)
        {
            ctx = context;
        }
    }
}
