using AutoMapper;
using LojaVirtual.Models;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaVirtual.Mappers
{
    public class FornecedorViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Fornecedor, FornecedorViewModel>();

            Mapper.CreateMap<FornecedorViewModel, Fornecedor>();
        }
    }
}