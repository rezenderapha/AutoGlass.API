using AutoGlass.API.Domain.Entities;
using System.Collections.Generic;

namespace AutoGlass.API.Domain.Dto
{
    public class FornecedorDtoAll
    {
        public int Id { get; set; }
        public bool SituacaoFornecedor { get; set; }
        public string Descricao { get; set; }
        public string Cnpj { get; set; }
        public IEnumerable<ProdutoDto> Produto { get; set; }
    }
}
