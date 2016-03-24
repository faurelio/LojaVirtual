using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LojaVirtual.Controllers
{
    public class ProdutoController : Controller
    {
        public ActionResult Lista()
        {
            var lista = new List<ProdutoViewModel>
            {
                new ProdutoViewModel
                {
                    Nome = "Chuteira Nike",
                    Categoria = "Calçados"
                },
                new ProdutoViewModel
                {
                    Nome = "Camisa Adidas",
                    Categoria = "Roupas"
                }
            };

            return View(lista);
        }

    }
}