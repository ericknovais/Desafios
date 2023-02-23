using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3.DomainModel.model
{
    public abstract class EntityBase
    {
        public int ID { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; }

        protected StringBuilder _mgsErro = new StringBuilder();

        public virtual void Validar()
        {
            if (_mgsErro.Length > 0)
                throw new Exception(_mgsErro.ToString());
        }

    }
}
