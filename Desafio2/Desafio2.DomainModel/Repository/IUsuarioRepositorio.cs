using Desafio2.DomainModel.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2.DomainModel.Repository
{
    public interface IUsuarioRepositorio : IRepositorioBase<Usuario>
    {
        IList<Usuario> UsuarioExiste(string login, string senha = "");
    }
}
