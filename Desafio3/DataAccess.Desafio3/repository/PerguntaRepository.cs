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
    class PerguntaRepository : AbstractRepository<Pergunta>, IPerguntaRepository
    {
        ContextDataBase ctx = new ContextDataBase();
        public PerguntaRepository(ContextDataBase context) : base(context)
        {
            ctx = context;
        }
    }
}
