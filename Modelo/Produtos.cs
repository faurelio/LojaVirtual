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
            var produtos = new List<Produto>();

            var produto1 = new Produto
            {
                Nome = "Chuteria Nike T90",
                Categoria = new Categoria
                {
                    Nome = "Calçados"
                }
            };

            produtos.Add(produto1);

            var produto2 = new Produto
            {
                Nome = "Camisa Adidas",
                Categoria = new Categoria
                {
                    Nome = "Roupas"
                }
            };

            produtos.Add(produto2);

            return produtos;
        }
    }
}
