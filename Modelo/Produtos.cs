using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Produtos
    {
        public IList<Produto> Lista()
        {
            using(var session = NHibernateHelper.OpenSession())
            {
                return session.QueryOver<Produto>()
                              .List();
            }
        }
    }
}
