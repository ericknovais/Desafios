namespace Desafio5.DataModel.repository
{
    public interface IRepository
    {
        void SaveChanges();
        IEnderecoRepository Endereco { get; }
    }
}
