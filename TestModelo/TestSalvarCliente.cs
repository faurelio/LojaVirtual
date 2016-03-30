using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelo;

namespace TestModelo
{
    [TestClass]
    public class TestSalvarCliente
    {
        [TestMethod]
        public void Salvar()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                session.Save(new Produto { Nome = "Chuteira Nike T90"});
                session.Flush();

            }
        }

        [TestMethod]
        public void TestSoma()
        {
            var fator1 = 2;
            var fator2 = 5;

            var matematica = new Matematica();
            var soma = matematica.Soma(fator1, fator2);

            Assert.AreEqual(7, soma);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DeveLancarExcecaoSeONomeForNulo()
        {
            var cliente = new Cliente();

            new Clientes().Salvar(cliente);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DeveLancarExcecaoSeONomeForVazio()
        {
            var cliente = new Cliente {
                Nome = ""
            };

            new Clientes().Salvar(cliente);
        }

    }
}
