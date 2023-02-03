using System;

namespace AutoGlass.API.Domain.Dto
{
    public class ProdutoFilterDto
    {
        public bool? SituacaoProduto { get; set; }
        public DateTime? DataFabricacao { get; set; }
        public DateTime? DataValidade { get; set; }
    }
}
