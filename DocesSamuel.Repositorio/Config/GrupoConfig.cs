using DocesSamuel.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocesSamuel.Repositorio.Config
{
    public class GrupoConfig : IEntityTypeConfiguration<Grupo>
    {
        public void Configure(EntityTypeBuilder<Grupo> builder)
        {
            builder.HasKey(grp => grp.IdGrupo);

            builder.Property(grp => grp.strNmGrupo).IsRequired().HasMaxLength(100);

        }
    }
}
