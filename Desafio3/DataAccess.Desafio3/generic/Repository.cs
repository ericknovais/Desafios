using Desafio3.DataAccess.db;
using Desafio3.DataAccess.repository;
using Desafio3.DomainModel.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3.DataAccess.generic
{
    public class Repository : IRepository
    {
        ContextDataBase ctx;

        public Repository()
        {
            ctx = new ContextDataBase();
        }

        IPerguntaRepository pergunta;
        public IPerguntaRepository Pergunta { get { return pergunta ?? (pergunta = new PerguntaRepository(ctx)); } }

        IRespostaRepository resposta;
        public IRespostaRepository Resposta { get { return resposta ?? (resposta = new RespostaRepository(ctx)); } }

        public void SaveChanges()
        {
            ctx.SaveChanges();
        }
    }
}
