using DocesSamuel.Dominio;
using DocesSamuel.Dominio.Entidades;
using DocesSamuel.Repositorio.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocesSamuel.Repositorio.Context
{
    public class DocesSamuelContext : DbContext
    {
        public DocesSamuelContext (DbContextOptions<DocesSamuelContext> options) : base(options)
        { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItemPedidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfig());
            modelBuilder.ApplyConfiguration(new ProdutoConfig());
            modelBuilder.ApplyConfiguration(new GrupoConfig());
            modelBuilder.ApplyConfiguration(new PedidoConfig());
            modelBuilder.ApplyConfiguration(new ItemPedConfig());

            base.OnModelCreating(modelBuilder);
        }

    }
}
