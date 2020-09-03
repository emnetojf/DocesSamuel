using DocesSamuel.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocesSamuel.Repositorio.Config
{
    public class UsuarioConfig : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(usr => usr.IdUsr);

            builder.Property(usr => usr.strNmUsr).IsRequired().HasMaxLength(100);
            builder.Property(usr => usr.strEmail).IsRequired().HasMaxLength(50);
            builder.Property(usr => usr.strSenha).IsRequired().HasMaxLength(20);
            builder.Property(usr => usr.booAdmin);
        }
    }
}
