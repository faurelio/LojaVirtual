using System;

namespace Modelo
{
    public class Fornecedor
    {
        public virtual Guid? Id { get; set; }

        public virtual string Nome { get; set; }

        public virtual string Endereco { get; set; }

        public virtual string Cidade { get; set; }
    }
}