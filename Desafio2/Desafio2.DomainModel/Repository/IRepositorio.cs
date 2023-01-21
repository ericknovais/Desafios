using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2.DomainModel.Repository
{
    public interface IRepositorio
    {
        void SaveChanges();

        IUsuarioRepositorio Usuario { get; }
    }
}
