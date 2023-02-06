﻿// <auto-generated />
using System;
using CalCalculatorDAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CalCalculatorDAL.Migrations
{
    [DbContext(typeof(CalCalculateDB))]
    partial class CalCalculateDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CalCalculatorEntities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("CalCalculatorEntities.Food", b =>
                {
                    b.Property<int>("FoodID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FoodID"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("FoodCal")
                        .HasColumnType("int");

                    b.Property<int>("FoodCarb")
                        .HasColumnType("int");

                    b.Property<int>("FoodFat")
                        .HasColumnType("int");

                    b.Property<string>("FoodName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FoodProt")
                        .HasColumnType("int");

                    b.Property<int>("Grams")
                        .HasColumnType("int");

                    b.HasKey("FoodID");

                    b.HasIndex("CategoryId");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("CalCalculatorEntities.FoodMeal", b =>
                {
                    b.Property<int>("MealID")
                        .HasColumnType("int");

                    b.Property<int>("FoodID")
                        .HasColumnType("int");

                    b.HasKey("MealID", "FoodID");

                    b.HasIndex("FoodID");

                    b.ToTable("FoodMeals");
                });

            modelBuilder.Entity("CalCalculatorEntities.Meal", b =>
                {
                    b.Property<int>("MealID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MealID"), 1L, 1);

                    b.Property<int>("ContactUserID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("MealName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MealID");

                    b.HasIndex("ContactUserID");

                    b.ToTable("Meals");
                });

            modelBuilder.Entity("CalCalculatorEntities.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("SecurityAnswer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityQuestion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CalCalculatorEntities.Food", b =>
                {
                    b.HasOne("CalCalculatorEntities.Category", "Category")
                        .WithMany("Foods")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("CalCalculatorEntities.FoodMeal", b =>
                {
                    b.HasOne("CalCalculatorEntities.Food", "Food")
                        .WithMany("FoodMeals")
                        .HasForeignKey("FoodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CalCalculatorEntities.Meal", "Meal")
                        .WithMany("FoodMeals")
                        .HasForeignKey("MealID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Food");

                    b.Navigation("Meal");
                });

            modelBuilder.Entity("CalCalculatorEntities.Meal", b =>
                {
                    b.HasOne("CalCalculatorEntities.User", "User")
                        .WithMany("Meals")
                        .HasForeignKey("ContactUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CalCalculatorEntities.Category", b =>
                {
                    b.Navigation("Foods");
                });

            modelBuilder.Entity("CalCalculatorEntities.Food", b =>
                {
                    b.Navigation("FoodMeals");
                });

            modelBuilder.Entity("CalCalculatorEntities.Meal", b =>
                {
                    b.Navigation("FoodMeals");
                });

            modelBuilder.Entity("CalCalculatorEntities.User", b =>
                {
                    b.Navigation("Meals");
                });
#pragma warning restore 612, 618
        }
    }
}
