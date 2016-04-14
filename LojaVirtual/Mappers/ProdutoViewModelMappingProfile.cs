using AutoMapper;
using LojaVirtual.Models;
using Modelo;

namespace LojaVirtual.Mappers
{
    public class ProdutoViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Produto, ProdutoListaViewModel>()
                  .ForMember(dest => dest.Categoria, opt => opt.MapFrom(src => src.Categoria.Nome))
                  .ForMember(dest => dest.Fornecedor, opt => opt.MapFrom(src => src.Fornecedor.Nome));

            Mapper.CreateMap<Produto, ProdutoViewModel>();

            Mapper.CreateMap<ProdutoViewModel, Produto>()
                  ;
        }
    }
}