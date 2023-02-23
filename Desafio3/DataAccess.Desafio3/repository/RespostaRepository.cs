using Desafio3.DataAccess.db;
using Desafio3.DataAccess.generic;
using Desafio3.DomainModel.model;
using Desafio3.DomainModel.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3.DataAccess.repository
{
    class RespostaRepository : AbstractRepository<Resposta>, IRespostaRepository
    {
        ContextDataBase ctx = new ContextDataBase();

        public RespostaRepository(ContextDataBase context) : base(context)
        {
            ctx = context;
        }

        public List<Resposta> ObterRespostaPorPerguntaId(int IdPergunta)
        {
            return ctx.Respostas.Where(x => x.PerguntaID == IdPergunta).ToList();
        }
    }
}
