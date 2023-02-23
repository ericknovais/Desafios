using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3.DomainModel.repository
{
    public interface IRepository
    {
        void SaveChanges();
        IPerguntaRepository Pergunta { get; }
        IRespostaRepository Resposta { get; }
    }
}
