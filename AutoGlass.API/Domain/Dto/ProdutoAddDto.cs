using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace AutoGlass.API.Domain.Dto
{
    public class ProdutoAddDto
    {
        public string DescricaoProduto { get; set; }
        public bool SituacaoProduto { get; set; }

        [Column(TypeName = "Date")]
        public DateTime? DataFabricacao { get; set; }

        [Column(TypeName = "Date")]
        public DateTime? DataValidade { get; set; }
        public int FornecedorId { get; set; }
    }
}
