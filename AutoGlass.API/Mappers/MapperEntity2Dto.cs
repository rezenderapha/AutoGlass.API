using AutoGlass.API.Domain.Dto;
using AutoGlass.API.Domain.Entities;
using AutoMapper;

namespace AutoGlass.API.Mappers
{
    public class MapperEntity2Dto : Profile
    {
        public MapperEntity2Dto()
        {
            CreateMap<Produto, ProdutoDto>();
            CreateMap<Produto, ProdutoAddDto>();
            CreateMap<Fornecedor, FornecedorFilterDto>();
            CreateMap<Fornecedor, FornecedorAddDto>();
            CreateMap<Fornecedor, FornecedorDto>();
            CreateMap<Fornecedor, FornecedorDtoAll>();
            CreateMap<Fornecedor, FornecedorUpdateDto>();
        }
    }
}
