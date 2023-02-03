using AutoGlass.API.Domain.Dto;

namespace AutoGlass.API.Domain.Common.Helpers.IHelpers
{
    public interface IValidate
    {
        bool CheckDate(ProdutoAddDto produtoAddDto);
    }
}
