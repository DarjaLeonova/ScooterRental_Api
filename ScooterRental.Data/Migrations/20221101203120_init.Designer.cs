﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ScooterRental.Data.Data;

#nullable disable

namespace ScooterRental.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221101203120_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ScooterRental.Core.Models.RentedScooter", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("PricePerMinute")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ScooterId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ScooterId");

                    b.ToTable("RentedScooters");
                });

            modelBuilder.Entity("ScooterRental.Core.Models.Scooter", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsRented")
                        .HasColumnType("bit");

                    b.Property<decimal>("PricePerMinute")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Scooters");
                });

            modelBuilder.Entity("ScooterRental.Core.Models.RentedScooter", b =>
                {
                    b.HasOne("ScooterRental.Core.Models.Scooter", "Scooter")
                        .WithMany()
                        .HasForeignKey("ScooterId");

                    b.Navigation("Scooter");
                });
#pragma warning restore 612, 618
        }
    }
}
