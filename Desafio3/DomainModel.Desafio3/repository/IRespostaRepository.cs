using Desafio3.DomainModel.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3.DomainModel.repository
{
    public interface IRespostaRepository : IRepositoryBase<Resposta>
    {
        List<Resposta> ObterRespostaPorPerguntaId(int IdPergunta);
    }
}
