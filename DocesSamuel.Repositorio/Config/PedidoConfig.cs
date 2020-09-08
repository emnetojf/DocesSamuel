using DocesSamuel.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocesSamuel.Repositorio.Config
{
    public class PedidoConfig : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(ped => ped.IdPed);

            builder.Property(ped => ped.dtPedido).IsRequired();
            builder.Property(ped => ped.UsuarioId).IsRequired();
            builder.Property(ped => ped.strObs).HasMaxLength(100);

            // Relacionamento
            builder.HasMany(ped => ped.ItemPedidos).WithOne(item => item.Pedido);
        }
    }
}
