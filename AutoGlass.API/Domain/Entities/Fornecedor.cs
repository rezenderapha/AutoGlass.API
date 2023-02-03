using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AutoGlass.API.Domain.Entities
{
    public class Fornecedor
    {
        public Fornecedor() { }

        public Fornecedor(int id, string descricao, string cnpj, bool situacaoFornecedor)
        {
            this.Id = id;
            this.Descricao = descricao;
            this.Cnpj = cnpj;
            this.SituacaoFornecedor = situacaoFornecedor;
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool SituacaoFornecedor { get; set; }
        public string Cnpj { get; set; }
        public IEnumerable<Produto> Produto { get; set; }
    }
}
