﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcMeal.Data;

namespace MvcMeals.Migrations
{
    [DbContext(typeof(MvcMealContext))]
    [Migration("20200402054230_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("MvcMeals.Models.Meal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cook")
                        .HasColumnType("TEXT");

                    b.Property<string>("DayOfWeek")
                        .HasColumnType("TEXT");

                    b.Property<string>("MainDish")
                        .HasColumnType("TEXT");

                    b.Property<string>("RecipeLink")
                        .HasColumnType("TEXT");

                    b.Property<string>("SideDish1")
                        .HasColumnType("TEXT");

                    b.Property<string>("SideDish2")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Meal");
                });
#pragma warning restore 612, 618
        }
    }
}
