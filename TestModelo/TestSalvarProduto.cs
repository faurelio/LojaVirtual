using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelo;

namespace TestModelo
{
    [TestClass]
    public class TestSalvarProduto
    {
        [TestMethod]
        public void Salvar()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                var produto = new Produto { Nome = "Chuteira Adidas" };

                session.Save(produto);
                session.Flush();

            }
        }
    }
}
