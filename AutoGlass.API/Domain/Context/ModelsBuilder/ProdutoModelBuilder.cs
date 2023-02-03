using AutoGlass.API.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoGlass.API.Domain.Context.ModelsBuilder
{
    public static class ProdutoModelBuilder
    {
        public static void AddBuilder(this EntityTypeBuilder<Produto> builder)
        {
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.DescricaoProduto).IsRequired().HasMaxLength(50);
            builder.Property(p => p.DataFabricacao);
            builder.Property(p => p.DataValidade);
            builder.HasOne(p => p.Fornecedor).WithMany(p => p.Produto).HasForeignKey(p => p.FornecedorId);     
        }
    }
}
