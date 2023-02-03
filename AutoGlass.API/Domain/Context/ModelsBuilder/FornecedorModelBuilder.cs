using AutoGlass.API.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoGlass.API.Domain.Context.ModelsBuilder
{
    public static class FornecedorModelBuilder
    {
        public static void AddBuilder(this EntityTypeBuilder<Fornecedor> builder)
        {
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.Descricao).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Cnpj).IsRequired().HasMaxLength(14);
            builder.Property(p => p.SituacaoFornecedor).IsRequired();
        }
    }
}
