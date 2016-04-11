using AutoMapper;
using LojaVirtual.Models;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaVirtual.Mappers
{
    public class CategoriaViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Categoria, CategoriaViewModel>();

            Mapper.CreateMap<CategoriaViewModel, Categoria>();
        }
    }
}