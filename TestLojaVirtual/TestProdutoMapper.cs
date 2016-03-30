using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelo;
using LojaVirtual.Models;
using AutoMapper;
using LojaVirtual.Mappers;

namespace TestLojaVirtual
{
    [TestClass]
    public class TestProdutoMapper
    {
        [TestInitialize]
        public void Init()
        {
            AutoMapperConfig.RegisterMappings();
        }

        [TestMethod]
        public void DeveMapearDeProdutoParaProdutoViewModel()
        {
            var produto = new Produto
            {
                Nome = "Chuteira Nike",
                Categoria = new Categoria
                {
                    Nome = "Calçados"
                }
            };

            var produtoViewModel = Mapper.Map<ProdutoViewModel>(produto);

            Assert.IsNotNull(produtoViewModel);
        }

        [TestMethod]
        public void DeveMapearNomeDoProduto()
        {
            var produto = new Produto
            {
                Nome = "Chuteira Nike",
                Categoria = new Categoria
                {
                    Nome = "Calçados"
                }
            };

            var produtoViewModel = Mapper.Map<ProdutoViewModel>(produto);

            Assert.AreEqual("Chuteira Nike", produtoViewModel.Nome);
        }

        [TestMethod]
        public void DeveMapearNomeDaCategoria()
        {
            var produto = new Produto
            {
                Nome = "Chuteira Nike",
                Categoria = new Categoria
                {
                    Nome = "Calçados"
                }
            };

            var produtoViewModel = Mapper.Map<ProdutoViewModel>(produto);

            Assert.AreEqual("Calçados", produtoViewModel.Categoria);
        }

    }
}
