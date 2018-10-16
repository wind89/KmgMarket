using EMarket.DAL.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EMarket.DAL
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedCategories(modelBuilder);
            SeedCategoryProperties(modelBuilder);
            SeedProducts(modelBuilder);
            SeedProductProperties(modelBuilder);

            modelBuilder.Entity<Models.Product>()
                .HasMany(x => x.Properties)
                .WithOne()
                .HasForeignKey(x=>x.ProductId)
                .OnDelete(DeleteBehavior.Restrict); 

            base.OnModelCreating(modelBuilder);
            
        }

        private void SeedCategories(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Category>().HasData(
              new Models.Category() { Id = new Guid("a9684bd6-b908-442f-b62f-63af9d478101"), Name = "Бытовая техника", CreatedAt = DateTime.Now },
              new Models.Category() { Id = new Guid("a9684bd6-b908-442f-b62f-63af9d418101"), Name = "Игрушки", CreatedAt = DateTime.Now }
              );
        }

        private void SeedCategoryProperties(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.CategoryProperty>().HasData(
              new Models.CategoryProperty() { Id = new Guid("b9684bd6-b908-442f-b62f-63af9d478101"), Nullable = false,  Name = "Размер", CategoryId = new Guid("a9684bd6-b908-442f-b62f-63af9d478101"), CreatedAt = DateTime.Now },
              new Models.CategoryProperty() { Id = new Guid("b9684bd6-b908-442f-b62f-63af9d478102"), Nullable = false, Name = "Цвет", CategoryId = new Guid("a9684bd6-b908-442f-b62f-63af9d478101"), CreatedAt = DateTime.Now },
              new Models.CategoryProperty() { Id = new Guid("b9684bd6-b908-442f-b62f-63af9d478103"), Nullable = false, Name = "Материал", CategoryId = new Guid("a9684bd6-b908-442f-b62f-63af9d478101"),  CreatedAt = DateTime.Now },

              new Models.CategoryProperty() { Id = new Guid("c9684bd6-b908-442f-b62f-63af9d478101"), Nullable = false, Name = "Цвет", CategoryId = new Guid("a9684bd6-b908-442f-b62f-63af9d418101"),  CreatedAt = DateTime.Now },
              new Models.CategoryProperty() { Id = new Guid("c9684bd6-b908-442f-b62f-63af9d478102"), Nullable = false, Name = "Страна", CategoryId = new Guid("a9684bd6-b908-442f-b62f-63af9d418101"),  CreatedAt = DateTime.Now }
                );
        }

        private void SeedProducts(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Product>().HasData(
              new Models.Product() { Id = new Guid("d9684bd6-b908-442f-b62f-63af9d478101"), Name = "Холодильник", CategoryId = new Guid("a9684bd6-b908-442f-b62f-63af9d478101"),  CreatedAt = DateTime.Now, Description = "-", Price = 100000},
              new Models.Product() { Id = new Guid("d9684bd6-b908-442f-b62f-63af9d478102"), Name = "Пазл", CategoryId = new Guid("a9684bd6-b908-442f-b62f-63af9d418101"), CreatedAt = DateTime.Now, Description = "-", Price = 3000 }
            );
        }

        private void SeedProductProperties(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.ProductProperty>().HasData(
              new Models.ProductProperty() { Id = new Guid("e9684bd6-b908-442f-b62f-63af9d478101"), ProductId = new Guid("d9684bd6-b908-442f-b62f-63af9d478101"), CategoryPropertyId = new Guid("b9684bd6-b908-442f-b62f-63af9d478101"), Value = "500x2000x500", CreatedAt = DateTime.Now },
              new Models.ProductProperty() { Id = new Guid("e9684bd6-b908-442f-b62f-63af9d478102"), ProductId = new Guid("d9684bd6-b908-442f-b62f-63af9d478101"), CategoryPropertyId = new Guid("b9684bd6-b908-442f-b62f-63af9d478102"), Value = "серый", CreatedAt = DateTime.Now },
              new Models.ProductProperty() { Id = new Guid("e9684bd6-b908-442f-b62f-63af9d478103"), ProductId = new Guid("d9684bd6-b908-442f-b62f-63af9d478101"), CategoryPropertyId = new Guid("b9684bd6-b908-442f-b62f-63af9d478103"), Value = "железный", CreatedAt = DateTime.Now },


              new Models.ProductProperty() { Id = new Guid("e9684bd6-b908-442f-b62f-63af9d478104"), ProductId = new Guid("d9684bd6-b908-442f-b62f-63af9d478102"), CategoryPropertyId = new Guid("c9684bd6-b908-442f-b62f-63af9d478101"), Value = "белый", CreatedAt = DateTime.Now },
              new Models.ProductProperty() { Id = new Guid("e9684bd6-b908-442f-b62f-63af9d478105"), ProductId = new Guid("d9684bd6-b908-442f-b62f-63af9d478102"), CategoryPropertyId = new Guid("c9684bd6-b908-442f-b62f-63af9d478102"), Value = "Китай", CreatedAt = DateTime.Now }
            );
        }

        public DbSet<Models.Category> Categories { get; set; }

        public DbSet<Models.CategoryProperty> CategoryProperties { get; set; }

        public DbSet<Models.Product> Products { get; set; }

        public DbSet<Models.ProductProperty> ProductProperties { get; set; }
    }

}
