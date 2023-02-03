using AutoGlass.API.Domain.Common.Helpers.IHelpers;
using AutoGlass.API.Domain.Dto;

namespace AutoGlass.API.Domain.Common.Helpers
{
    public class Validate : IValidate
    {
        public bool CheckDate(ProdutoAddDto produtoAddDto)
        {
            bool response;

            if (!produtoAddDto.DataFabricacao.HasValue || !produtoAddDto.DataValidade.HasValue)
            {
                return false;
            }
            else
            {
                response = (produtoAddDto.DataFabricacao < produtoAddDto.DataValidade)?  true :  false;
            }
            return response;
        }
    }
}
