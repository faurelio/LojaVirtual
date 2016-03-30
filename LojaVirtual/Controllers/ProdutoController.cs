using AutoMapper;
using LojaVirtual.Models;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace LojaVirtual.Controllers
{
    public class ProdutoController : Controller
    {
        public ActionResult Lista()
        {
            var produtos = new Produtos();

            var listaProdutos = produtos.Lista();

            var lista = Mapper.Map<IList<ProdutoViewModel>>(listaProdutos);

            return View(lista);
        }

    }
}