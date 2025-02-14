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
    [Migration("20241014181043_Set Email As Key for User Table")]
    partial class SetEmailAsKeyforUserTable
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
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

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

                    b.HasKey("Email");

                    b.HasIndex("Province", "City");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Email = "zhangsan@example.com",
                            Age = 26,
                            City = "上海",
                            Gender = 0,
                            Name = "張三",
                            Password = "password123",
                            Province = "上海"
                        },
                        new
                        {
                            Email = "lisi@example.com",
                            Age = 25,
                            City = "北京",
                            Gender = 1,
                            Name = "李四",
                            Password = "password123",
                            Province = "北京"
                        },
                        new
                        {
                            Email = "wangwu@example.com",
                            Age = 20,
                            City = "廣州",
                            Gender = 0,
                            Name = "王五",
                            Password = "password123",
                            Province = "廣東"
                        },
                        new
                        {
                            Email = "zhaoliu@example.com",
                            Age = 30,
                            City = "深圳",
                            Gender = 1,
                            Name = "趙六",
                            Password = "password123",
                            Province = "廣東"
                        },
                        new
                        {
                            Email = "sunqi@example.com",
                            Age = 22,
                            City = "珠海",
                            Gender = 0,
                            Name = "孫七",
                            Password = "password123",
                            Province = "廣東"
                        },
                        new
                        {
                            Email = "zhouba@example.com",
                            Age = 28,
                            City = "南寧",
                            Gender = 1,
                            Name = "周八",
                            Password = "password123",
                            Province = "廣西"
                        },
                        new
                        {
                            Email = "wujia@example.com",
                            Age = 24,
                            City = "桂林",
                            Gender = 0,
                            Name = "吳九",
                            Password = "password123",
                            Province = "廣西"
                        },
                        new
                        {
                            Email = "zhengshi@example.com",
                            Age = 27,
                            City = "廈門",
                            Gender = 1,
                            Name = "鄭十",
                            Password = "password123",
                            Province = "福建"
                        },
                        new
                        {
                            Email = "wangyi@example.com",
                            Age = 23,
                            City = "福州",
                            Gender = 0,
                            Name = "王一",
                            Password = "password123",
                            Province = "福建"
                        },
                        new
                        {
                            Email = "liuer@example.com",
                            Age = 29,
                            City = "上海",
                            Gender = 1,
                            Name = "李二",
                            Password = "password123",
                            Province = "上海"
                        },
                        new
                        {
                            Email = "zhangsan2@example.com",
                            Age = 21,
                            City = "北京",
                            Gender = 0,
                            Name = "張三二",
                            Password = "password123",
                            Province = "北京"
                        },
                        new
                        {
                            Email = "lisi2@example.com",
                            Age = 26,
                            City = "廣州",
                            Gender = 1,
                            Name = "李四二",
                            Password = "password123",
                            Province = "廣東"
                        },
                        new
                        {
                            Email = "wangwu2@example.com",
                            Age = 22,
                            City = "深圳",
                            Gender = 0,
                            Name = "王五二",
                            Password = "password123",
                            Province = "廣東"
                        },
                        new
                        {
                            Email = "zhaoliu2@example.com",
                            Age = 31,
                            City = "珠海",
                            Gender = 1,
                            Name = "趙六二",
                            Password = "password123",
                            Province = "廣東"
                        },
                        new
                        {
                            Email = "sunqi2@example.com",
                            Age = 23,
                            City = "上海",
                            Gender = 1,
                            Name = "孫七二",
                            Password = "password123",
                            Province = "上海"
                        });
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
