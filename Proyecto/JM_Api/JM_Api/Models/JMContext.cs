using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;

namespace JM_Api.Models
{
    public class JMContext : DbContext
    {
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ProductoPedido> ProductosPedidos { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<InformacionPago> InformacionPagos { get; set; }
        public DbSet<Transaccion> Transacciones { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<DireccionEnvio> DireccionesEnvio { get; set; }
        public DbSet<Administrador> Administradores { get; set; }

        public JMContext()
        {
        }

        public JMContext(DbContextOptions options)
        : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=localhost;Database=JMShopEntity;User=root;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}