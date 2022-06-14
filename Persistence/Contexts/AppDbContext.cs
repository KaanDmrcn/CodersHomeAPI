using CodersHomeAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CodersHomeAPI.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Category>().ToTable("Categories");
            builder.Entity<Category>().HasKey(p => p.Id);
            builder.Entity<Category>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Category>().Property(p => p.Name).IsRequired().HasMaxLength(30);
            builder.Entity<Category>().HasData
            (
                new Category() { Name = "Kupa", Id = 1 },
                new Category() { Name = "Rozet", Id = 2 },
                new Category() { Name = "Defter", Id = 3 }
            );
            builder.Entity<Product>().ToTable("Products");
            builder.Entity<Product>().HasKey(p => p.Id);
            builder.Entity<Product>().Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Entity<Product>().Property(p => p.Name).IsRequired();
            builder.Entity<Product>().Property(p => p.ImageURL).IsRequired();
            builder.Entity<Product>().Property(p => p.Cost).IsRequired();
            builder.Entity<Product>().Property(p => p.CategoryID).IsRequired();

            builder.Entity<Product>().HasData
            (
                new Product() { Id = 1, Name = "WordPres Temalı Yazılımcı Kupası", Cost = 42.95, ImageURL = "https://i0.wp.com/www.codershome.net/wp-content/uploads/2022/03/wordpress1-min.jpg?fit=1600%2C1200;ssl=1", CategoryName = "Kupa", CategoryID = 1 },
                new Product() { Id = 2, Name = "Lua Temalı Yazılımcı Kupası", Cost = 42.95, ImageURL = "https://i0.wp.com/www.codershome.net/wp-content/uploads/2022/03/lua-1-min.jpg?fit=1600%2C1200;ssl=1", CategoryName = "Kupa", CategoryID = 1 },
                new Product() { Id = 3, Name = "Pardus Temalı Yazılımcı Kupası", Cost = 42.95, ImageURL = "https://i0.wp.com/www.codershome.net/wp-content/uploads/2022/03/pardus-1-min.jpg?fit=1600%2C1200;ssl=1", CategoryName = "Kupa", CategoryID = 1 },
                new Product() { Id = 4, Name = "Flutter Temalı Yazılımcı İğneli Rozet", Cost = 7.50, ImageURL = "https://i0.wp.com/www.codershome.net/wp-content/uploads/2021/09/IMG_4120-min-scaled.jpg?fit=2560%2C2560;ssl=1", CategoryName = "Rozet", CategoryID = 2 },
                new Product() { Id = 5, Name = "Don't Disturb Karton Kapaklı Yazılımcı Siyah Defter", Cost = 54.95, ImageURL = "https://i0.wp.com/www.codershome.net/wp-content/uploads/2021/09/dont-disturb-min.jpg?fit=1200%2C1200;ssl=1", CategoryName = "Defter", CategoryID = 3 },
                new Product() { Id = 6, Name = "Anti Coding Coding Club Yazılımcı Siyah Defter", Cost = 54.95, ImageURL = "https://i0.wp.com/www.codershome.net/wp-content/uploads/2021/09/anti-coding-min.jpg?fit=1200%2C1200;ssl=1", CategoryName = "Defter", CategoryID = 3 }
            );

        }
    }
}
