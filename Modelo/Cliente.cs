using NHibernate.Mapping.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    [Class(Table = "CLIENTE")]
    public class Cliente
    {
        [Id]
        public long Id { get; set; }
        [Property]
        public string Nome { get; set; }

        public string Cpf { get; set; }
    }
}
