﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaVirtual.Mappers
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<ProdutoViewModelMappingProfile>();
                x.AddProfile<FornecedorViewModelMappingProfile>();
                x.AddProfile<FornecedorViewModelMappingProfile>();
            });
        }
    }
}