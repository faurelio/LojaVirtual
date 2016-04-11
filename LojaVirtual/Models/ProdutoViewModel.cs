using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LojaVirtual.Models
{
    public class ProdutoViewModel
    {
        public Guid? Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Categoria é obrigatório.")]
        public CategoriaViewModel Categoria { get; set; }

        public IList<CategoriaViewModel> Categorias { get; set; }
    }
}