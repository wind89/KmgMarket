﻿// <auto-generated />
using System;
using EMarket.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EMarket.DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20181016101058_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EMarket.DAL.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("EMarket.DAL.Models.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new { Id = new Guid("a9684bd6-b908-442f-b62f-63af9d478101"), CreatedAt = new DateTime(2018, 10, 16, 16, 10, 55, 261, DateTimeKind.Local), Name = "Бытовая техника" },
                        new { Id = new Guid("a9684bd6-b908-442f-b62f-63af9d418101"), CreatedAt = new DateTime(2018, 10, 16, 16, 10, 55, 263, DateTimeKind.Local), Name = "Игрушки" }
                    );
                });

            modelBuilder.Entity("EMarket.DAL.Models.CategoryProperty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CategoryId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<bool>("Nullable");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("CategoryProperties");

                    b.HasData(
                        new { Id = new Guid("b9684bd6-b908-442f-b62f-63af9d478101"), CategoryId = new Guid("a9684bd6-b908-442f-b62f-63af9d478101"), CreatedAt = new DateTime(2018, 10, 16, 16, 10, 55, 270, DateTimeKind.Local), Name = "Размер", Nullable = false },
                        new { Id = new Guid("b9684bd6-b908-442f-b62f-63af9d478102"), CategoryId = new Guid("a9684bd6-b908-442f-b62f-63af9d478101"), CreatedAt = new DateTime(2018, 10, 16, 16, 10, 55, 271, DateTimeKind.Local), Name = "Цвет", Nullable = false },
                        new { Id = new Guid("b9684bd6-b908-442f-b62f-63af9d478103"), CategoryId = new Guid("a9684bd6-b908-442f-b62f-63af9d478101"), CreatedAt = new DateTime(2018, 10, 16, 16, 10, 55, 271, DateTimeKind.Local), Name = "Материал", Nullable = false },
                        new { Id = new Guid("c9684bd6-b908-442f-b62f-63af9d478101"), CategoryId = new Guid("a9684bd6-b908-442f-b62f-63af9d418101"), CreatedAt = new DateTime(2018, 10, 16, 16, 10, 55, 271, DateTimeKind.Local), Name = "Цвет", Nullable = false },
                        new { Id = new Guid("c9684bd6-b908-442f-b62f-63af9d478102"), CategoryId = new Guid("a9684bd6-b908-442f-b62f-63af9d418101"), CreatedAt = new DateTime(2018, 10, 16, 16, 10, 55, 271, DateTimeKind.Local), Name = "Страна", Nullable = false }
                    );
                });

            modelBuilder.Entity("EMarket.DAL.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CategoryId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new { Id = new Guid("d9684bd6-b908-442f-b62f-63af9d478101"), CategoryId = new Guid("a9684bd6-b908-442f-b62f-63af9d478101"), CreatedAt = new DateTime(2018, 10, 16, 16, 10, 55, 273, DateTimeKind.Local), Description = "-", Name = "Холодильник", Price = 100000m },
                        new { Id = new Guid("d9684bd6-b908-442f-b62f-63af9d478102"), CategoryId = new Guid("a9684bd6-b908-442f-b62f-63af9d418101"), CreatedAt = new DateTime(2018, 10, 16, 16, 10, 55, 274, DateTimeKind.Local), Description = "-", Name = "Пазл", Price = 3000m }
                    );
                });

            modelBuilder.Entity("EMarket.DAL.Models.ProductProperty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CategoryPropertyId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<Guid>("ProductId");

                    b.Property<Guid?>("ProductId1");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("CategoryPropertyId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProductId1");

                    b.ToTable("ProductProperties");

                    b.HasData(
                        new { Id = new Guid("e9684bd6-b908-442f-b62f-63af9d478101"), CategoryPropertyId = new Guid("b9684bd6-b908-442f-b62f-63af9d478101"), CreatedAt = new DateTime(2018, 10, 16, 16, 10, 55, 278, DateTimeKind.Local), ProductId = new Guid("d9684bd6-b908-442f-b62f-63af9d478101"), Value = "500x2000x500" },
                        new { Id = new Guid("e9684bd6-b908-442f-b62f-63af9d478102"), CategoryPropertyId = new Guid("b9684bd6-b908-442f-b62f-63af9d478102"), CreatedAt = new DateTime(2018, 10, 16, 16, 10, 55, 278, DateTimeKind.Local), ProductId = new Guid("d9684bd6-b908-442f-b62f-63af9d478101"), Value = "серый" },
                        new { Id = new Guid("e9684bd6-b908-442f-b62f-63af9d478103"), CategoryPropertyId = new Guid("b9684bd6-b908-442f-b62f-63af9d478103"), CreatedAt = new DateTime(2018, 10, 16, 16, 10, 55, 278, DateTimeKind.Local), ProductId = new Guid("d9684bd6-b908-442f-b62f-63af9d478101"), Value = "железный" },
                        new { Id = new Guid("e9684bd6-b908-442f-b62f-63af9d478104"), CategoryPropertyId = new Guid("c9684bd6-b908-442f-b62f-63af9d478101"), CreatedAt = new DateTime(2018, 10, 16, 16, 10, 55, 278, DateTimeKind.Local), ProductId = new Guid("d9684bd6-b908-442f-b62f-63af9d478102"), Value = "белый" },
                        new { Id = new Guid("e9684bd6-b908-442f-b62f-63af9d478105"), CategoryPropertyId = new Guid("c9684bd6-b908-442f-b62f-63af9d478102"), CreatedAt = new DateTime(2018, 10, 16, 16, 10, 55, 278, DateTimeKind.Local), ProductId = new Guid("d9684bd6-b908-442f-b62f-63af9d478102"), Value = "Китай" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("EMarket.DAL.Models.CategoryProperty", b =>
                {
                    b.HasOne("EMarket.DAL.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EMarket.DAL.Models.Product", b =>
                {
                    b.HasOne("EMarket.DAL.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EMarket.DAL.Models.ProductProperty", b =>
                {
                    b.HasOne("EMarket.DAL.Models.CategoryProperty", "CategoryProperty")
                        .WithMany()
                        .HasForeignKey("CategoryPropertyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EMarket.DAL.Models.Product")
                        .WithMany("Properties")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("EMarket.DAL.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId1");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("EMarket.DAL.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("EMarket.DAL.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EMarket.DAL.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("EMarket.DAL.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
