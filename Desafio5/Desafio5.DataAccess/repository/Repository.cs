using Desafio5.DataAccess.db;
using Desafio5.DataModel.repository;

namespace Desafio5.DataAccess.repository
{
    public class Repository : IRepository
    {
        ContextDataBase ctx;

        public Repository()
        {
            ctx = new ContextDataBase();
        }

        IEnderecoRepository endereco;
        public IEnderecoRepository Endereco { get { return endereco ?? (endereco = new EnderecoRepository(ctx)); } }

        public void SaveChanges()
        {
            ctx.SaveChanges();
        }
    }
}
