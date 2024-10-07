using Microsoft.EntityFrameworkCore;
namespace Sinitsyna.Models
{
    public class AppDbContext: DbContext
    {
        public DbSet<Boutique> Boutiques { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductMaterial> ProductMaterials { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<DataAuthorization> DataAuthorizations { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            Database.EnsureCreated();   
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Boutique>()
                .HasKey(b => b.Id_boutique);

            modelBuilder.Entity<Product>()
                .HasKey(p => p.Id_product);

            modelBuilder.Entity<ProductImage>()
                .HasKey(pi => pi.Id_image);

            modelBuilder.Entity<ProductType>()
                .HasKey(pt => pt.Id_type);

            modelBuilder.Entity<ProductMaterial>()
                .HasKey(pm => pm.Id_material);

            modelBuilder.Entity<Role>()
                .HasKey(r => r.Id_role);

            modelBuilder.Entity<User>()
                .HasKey(u => u.Id_user);

            modelBuilder.Entity<DataAuthorization>()
                .HasKey(da => da.Id_auth);

            modelBuilder.Entity<Favorite>()
                .HasKey(f => f.Id_favorite);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.ProductType)
                .WithMany()
                .HasForeignKey(p => p.Id_type);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.ProductMaterial)
                .WithMany()
                .HasForeignKey(p => p.Id_material);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Boutique)
                .WithMany(b => b.Products)
                .HasForeignKey(p => p.Id_boutique);

            modelBuilder.Entity<ProductImage>()
                .HasOne(pi => pi.Product)
                .WithMany(p => p.ProductImages)
                .HasForeignKey(pi => pi.Id_product);

            modelBuilder.Entity<DataAuthorization>()
                .HasOne(da => da.User)
                .WithMany()
                .HasForeignKey(da => da.Id_user);

            modelBuilder.Entity<Favorite>()
                .HasOne(f => f.User)
                .WithMany()
                .HasForeignKey(f => f.Id_user);

            modelBuilder.Entity<Favorite>()
                .HasOne(f => f.Product)
                .WithMany()
                .HasForeignKey(f => f.Id_product);
        }

    }
}
