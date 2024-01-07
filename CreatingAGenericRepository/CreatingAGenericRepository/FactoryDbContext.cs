using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace CreatingAGenericRepository
{
    public partial class FactoryDbContext : DbContext
    {
        public FactoryDbContext() { }

        public FactoryDbContext(DbContextOptions<FactoryDbContext> options)
            : base(options) { }

        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductPriceHistory> ProductPriceHistory { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("connection_string");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Lithuanian_Lithuania.1252");

            modelBuilder.Entity<Manufacturer>(entity =>
            {
                entity.ToTable("Manufacturer", "Factory");

                entity.Property(e => e.Country).IsRequired().HasMaxLength(50);

                entity.Property(e => e.Name).IsRequired().HasMaxLength(50);

                entity.Property(e => e.FoundedAt).HasColumnType("date");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product", "Factory");

                entity.Property(e => e.Name).IsRequired().HasMaxLength(50);

                RelationalForeignKeyBuilderExtensions.HasConstraintName(
                    (ReferenceCollectionBuilder)
                        entity
                            .HasOne(d => d.Manufacturer)
                            .WithMany(p => p.Products)
                            .HasForeignKey(d => d.ManufacturerId),
                    "FK_Product_Manufacturer"
                );
            });

            modelBuilder.Entity<ProductPriceHistory>(entity =>
            {
                entity.ToTable("ProductPriceHistory", "Factory");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.DateOfPrice).HasColumnType("date");

                RelationalForeignKeyBuilderExtensions.HasConstraintName(
                    (ReferenceCollectionBuilder)
                        entity
                            .HasOne(d => d.Product)
                            .WithMany(p => p.PriceHistory)
                            .HasForeignKey(d => d.ProductId),
                    "FK_ProductPriceHistory_Product"
                );
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
