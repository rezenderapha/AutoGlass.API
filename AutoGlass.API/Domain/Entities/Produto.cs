using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AutoGlass.API.Domain.Entities
{
    public class Produto
    {
        public Produto() { }
        
        public Produto(int id, string descricaoProduto, bool situacaoProduto, DateTime? dataFabricacao, DateTime? dataValidade, int fornecedorId)
        {
            this.Id = id;
            this.DescricaoProduto = descricaoProduto;
            this.SituacaoProduto = situacaoProduto;
            this.DataFabricacao = dataFabricacao;
            this.DataValidade = dataValidade;
            this.FornecedorId = fornecedorId;
        }

        public int Id { get; set; }
        public string DescricaoProduto { get; set; }
        public bool SituacaoProduto { get; set; }

        [Column(TypeName = "Date")]
        public DateTime? DataFabricacao { get; set; }

        [Column(TypeName = "Date")]
        public DateTime? DataValidade { get; set; }
        public int FornecedorId { get; set; }
        public Fornecedor Fornecedor { get; set; }
    }
}
