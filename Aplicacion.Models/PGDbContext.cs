using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Aplicacion.Models
{
     public class PGDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ClienteProducto> ClientesProductos { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Artefacto> Artefactos { get; set; }
        public PGDbContext() : base(nameOrConnectionString: "DefaultConnectionString") { this.Configuration.LazyLoadingEnabled = false; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //new DropCreateDatabaseIfModelChanges<PGDbContext>()
            Database.SetInitializer<PGDbContext>(null);
            modelBuilder.Entity<Cliente>().ToTable("tbl_cliente", "esqmicriservempresa");
            modelBuilder.Entity<ClienteProducto>().ToTable("tbl_cliente_producto", "esqmicriservempresa");
            modelBuilder.Entity<Empresa>().ToTable("tbl_empresa", "esqmicriservempresa");
            modelBuilder.Entity<Producto>().ToTable("tbl_producto", "esqmicriservempresa");
            modelBuilder.Entity<Usuario>().ToTable("tbl_usuario", "esqmicriservempresa");
            modelBuilder.Entity<Artefacto>().ToTable("tbl_artefacto1", "esqmicriservempresa");
        }
    }
}
