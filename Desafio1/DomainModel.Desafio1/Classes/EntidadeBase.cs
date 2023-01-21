using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Desafio1.Classes
{
    public abstract class EntidadeBase
    {
        public int ID { get; set; }

        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }

        protected StringBuilder _msgErro = new StringBuilder();

        public virtual void Validar()
        {
            if (_msgErro.Length > 0)
                throw new Exception(_msgErro.ToString());            
        }
    }
}
