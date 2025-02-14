﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(UserDbContext))]
    [Migration("20241014115409_Initialize Location")]
    partial class InitializeLocation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Model.Domain.Location", b =>
                {
                    b.Property<string>("Province")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Province", "City");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Province = "廣東",
                            City = "廣州"
                        },
                        new
                        {
                            Province = "廣東",
                            City = "深圳"
                        },
                        new
                        {
                            Province = "廣東",
                            City = "珠海"
                        },
                        new
                        {
                            Province = "福建",
                            City = "福州"
                        },
                        new
                        {
                            Province = "福建",
                            City = "廈門"
                        },
                        new
                        {
                            Province = "廣西",
                            City = "南寧"
                        },
                        new
                        {
                            Province = "廣西",
                            City = "桂林"
                        },
                        new
                        {
                            Province = "上海",
                            City = "上海"
                        },
                        new
                        {
                            Province = "北京",
                            City = "北京"
                        });
                });

            modelBuilder.Entity("Model.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Province", "City");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Model.Domain.User", b =>
                {
                    b.HasOne("Model.Domain.Location", "Location")
                        .WithMany()
                        .HasForeignKey("Province", "City")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });
#pragma warning restore 612, 618
        }
    }
}
