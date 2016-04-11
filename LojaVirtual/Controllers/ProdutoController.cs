using AutoMapper;
using LojaVirtual.Models;
using Modelo;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace LojaVirtual.Controllers
{
    public class ProdutoController : Controller
    {
        public ActionResult Lista()
        {
            var produtos = new Produtos();

            var listaProdutos = produtos.Lista();

            var lista = Mapper.Map<IList<ProdutoListaViewModel>>(listaProdutos);

            return View(lista);
        }

        public ActionResult Editar(Guid? id = null)
        {
            ProdutoViewModel viewModel; 

            if (id != null)
            {
                var produtos = new Produtos();

                var produto = produtos.Por(id);

                viewModel = Mapper.Map<ProdutoViewModel>(produto);
            } else
            {
                viewModel = new ProdutoViewModel();
            }

            var categorias = new Categorias();

            var listaCategorias = categorias.Lista();

            viewModel.Categorias = Mapper.Map<IList<CategoriaViewModel>>(listaCategorias);

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(ProdutoViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var produtos = new Produtos();

                var produto = Mapper.Map<Produto>(viewModel);

                produtos.Salvar(produto);

                return RedirectToAction("Lista");
            }

            return View(viewModel);
        }

        public ActionResult Apagar(Guid id)
        {
            var produtos = new Produtos();

            produtos.Apagar(id);

            return RedirectToAction("Lista");
        }
    }
}