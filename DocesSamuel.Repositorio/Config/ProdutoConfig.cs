using DocesSamuel.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocesSamuel.Repositorio.Config
{
    public class ProdutoConfig : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(prod => prod.IdProd);

            builder.Property(prod => prod.strNmProd).IsRequired().HasMaxLength(100);
            builder.Property(prod => prod.douPrecoUnit).IsRequired();
            builder.Property(prod => prod.strNomeArq).HasMaxLength(100);

            // Relacionamento
            builder.HasMany(prod => prod.itemPedidos).WithOne(item => item.Produto);
        }
    }
}
