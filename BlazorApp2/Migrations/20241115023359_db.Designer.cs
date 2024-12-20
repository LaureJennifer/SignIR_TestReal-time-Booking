﻿// <auto-generated />
using System;
using BlazorApp2;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorApp2.Migrations
{
    [DbContext(typeof(DBSeat))]
    [Migration("20241115023359_db")]
    partial class db
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorApp2.Seat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Row")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeatColumn")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Seats");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e0e12a8a-10e6-4186-b5df-81c7c923ec0f"),
                            Code = "A1",
                            Price = 45.0,
                            Row = "A1",
                            SeatColumn = 1,
                            Status = 2
                        },
                        new
                        {
                            Id = new Guid("e0e12a8a-10e6-4186-b5df-81c7c923ec1f"),
                            Code = "A2",
                            Price = 45.0,
                            Row = "A2",
                            SeatColumn = 2,
                            Status = 2
                        },
                        new
                        {
                            Id = new Guid("e0e12a8a-10e6-4186-b5df-81c7c923ec2f"),
                            Code = "B1",
                            Price = 45.0,
                            Row = "B2",
                            SeatColumn = 1,
                            Status = 2
                        },
                        new
                        {
                            Id = new Guid("e0e12a8a-10e6-4186-b5df-81c7c923ec3f"),
                            Code = "B2",
                            Price = 45.0,
                            Row = "B2",
                            SeatColumn = 2,
                            Status = 2
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
