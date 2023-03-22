using System;
using System.Text;

namespace Desafio5.DataModel.model
{
    public abstract class EntityBase
    {
        public int ID { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; }

        public StringBuilder _msgErro = new StringBuilder();

        public virtual void Validar()
        {
            if (_msgErro.Length > 0)
                throw new Exception(_msgErro.ToString());
        }
    }
}
