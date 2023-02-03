using AutoGlass.API.Domain.Dto;
using AutoGlass.API.Domain.Entities;
using AutoMapper;

namespace AutoGlass.API.Mappers
{
    public class MapperDto2Entity : Profile
    {
        public MapperDto2Entity()
        {
            CreateMap<ProdutoDto, Produto>();
            CreateMap<ProdutoAddDto, Produto>();
            CreateMap<FornecedorFilterDto, Fornecedor>();
            CreateMap<FornecedorAddDto, Fornecedor>();
            CreateMap<FornecedorDto, Fornecedor>();
            CreateMap<FornecedorDtoAll, Fornecedor>();
            CreateMap<FornecedorUpdateDto, Fornecedor>();

        }
        
    }
}
