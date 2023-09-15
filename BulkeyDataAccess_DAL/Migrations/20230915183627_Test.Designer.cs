﻿// <auto-generated />
using System;
using BulkeyDataAccess_DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BulkeyDataAccess_DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230915183627_Test")]
    partial class Test
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-rc.1.23419.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BulkeyModels.Models.Domain.Catagory", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Catagories");

                    b.HasData(
                        new
                        {
                            ID = new Guid("7469fc0c-9c23-48a7-8909-7c678243e786"),
                            DisplayOrder = 1,
                            Name = "Action"
                        },
                        new
                        {
                            ID = new Guid("c81c000c-41c0-41b4-8c34-561bee24bea9"),
                            DisplayOrder = 2,
                            Name = "SciFi"
                        },
                        new
                        {
                            ID = new Guid("f36a0935-38b6-4721-86f1-d8eb43f45279"),
                            DisplayOrder = 3,
                            Name = "History"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
