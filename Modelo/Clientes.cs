using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Clientes
    {
        public void Salvar(Cliente cliente)
        {
            if (string.IsNullOrEmpty(cliente.Nome))
            {
                throw new ArgumentException("Nome não pode ser nulo.");
            }
            

        }
    }
}
