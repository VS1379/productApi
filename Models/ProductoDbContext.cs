using Microsoft.EntityFrameworkCore;
using ProductosApi.Models;

namespace ProductosApi
{
    public class ProductoDbContext : DbContext
    {
        public ProductoDbContext(DbContextOptions<ProductoDbContext> options) : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);
                entity.Property(e => e.Marca).IsRequired();
                entity.Property(e => e.Alto).IsRequired();
                entity.Property(e => e.Ancho).IsRequired();
                entity.Property(e => e.Profundidad).IsRequired();
                entity.Property(e => e.Peso).HasDefaultValue(0);
            });
        }
    }
}
