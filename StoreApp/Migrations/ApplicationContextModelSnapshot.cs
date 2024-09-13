﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace StoreApp.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("StoreApp.Models.Box", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("Depth")
                        .HasColumnType("double precision");

                    b.Property<DateOnly?>("ExpirationDate")
                        .HasColumnType("date");

                    b.Property<double>("Height")
                        .HasColumnType("double precision");

                    b.Property<int?>("PalletId")
                        .HasColumnType("integer");

                    b.Property<DateOnly>("ProductionDate")
                        .HasColumnType("date");

                    b.Property<double?>("Volume")
                        .HasColumnType("double precision");

                    b.Property<double?>("Weight")
                        .HasColumnType("double precision");

                    b.Property<double>("Width")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("Boxes");
                });

            modelBuilder.Entity("StoreApp.Models.Pallet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("Depth")
                        .HasColumnType("double precision");

                    b.Property<DateOnly?>("ExpirationDate")
                        .HasColumnType("date");

                    b.Property<double>("Height")
                        .HasColumnType("double precision");

                    b.Property<double?>("Volume")
                        .HasColumnType("double precision");

                    b.Property<double?>("Weight")
                        .HasColumnType("double precision");

                    b.Property<double>("Width")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("Pallets");
                });
#pragma warning restore 612, 618
        }
    }
}
