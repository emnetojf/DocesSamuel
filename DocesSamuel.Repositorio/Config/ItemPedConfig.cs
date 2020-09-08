using DocesSamuel.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocesSamuel.Repositorio.Config
{
    public class ItemPedConfig : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.HasKey(item => item.IdItem);

            builder.Property(item => item.PedidoId).IsRequired();
            builder.Property(item => item.ProdutoId).IsRequired();
            builder.Property(item => item.douQuant).IsRequired();

        }
    }
}
