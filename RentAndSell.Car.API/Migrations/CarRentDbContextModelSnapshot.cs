﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RentAndSell.Car.API.Data.Context;

#nullable disable

namespace RentAndSell.Car.API.Migrations
{
    [DbContext(typeof(CarRentDbContext))]
    partial class CarRentDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RentAndSell.Car.API.Data.Entities.Concrete.Araba", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Delete")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Marka")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MotorTipi")
                        .HasColumnType("int");

                    b.Property<int>("SanzimanTipi")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Update")
                        .HasColumnType("datetime2");

                    b.Property<int>("YakitTuru")
                        .HasColumnType("int");

                    b.Property<short>("Yili")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.ToTable("Arabalar");
                });
#pragma warning restore 612, 618
        }
    }
}
