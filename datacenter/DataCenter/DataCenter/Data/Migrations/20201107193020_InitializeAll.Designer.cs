﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataCenter.Data.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20201107193020_InitializeAll")]
    partial class InitializeAll
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DataCenter.Data.Models.Bank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Cash")
                        .HasColumnType("double");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<double>("Credit")
                        .HasColumnType("double");

                    b.Property<double>("Debit")
                        .HasColumnType("double");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("UnitId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("Bank");
                });

            modelBuilder.Entity("DataCenter.Data.Models.Credentials", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("GeneratedToken")
                        .IsRequired()
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("Tag")
                        .HasColumnType("nvarchar(4096)");

                    b.HasKey("Id");

                    b.ToTable("Credentials");
                });

            modelBuilder.Entity("DataCenter.Data.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Administrator")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Attributes")
                        .HasColumnType("nvarchar(128)");

                    b.Property<int>("Bonus")
                        .HasColumnType("int");

                    b.Property<bool>("Builder")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Group")
                        .HasColumnType("nvarchar(128)");

                    b.Property<DateTime>("JoinedDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("LeftDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Licenses")
                        .HasColumnType("nvarchar(128)");

                    b.Property<int>("MinutesPlayed")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)");

                    b.Property<int>("Organisation")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(4096)");

                    b.Property<string>("People")
                        .HasColumnType("nvarchar(4096)");

                    b.Property<bool>("Realtor")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Tag")
                        .HasColumnType("nvarchar(4096)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.Property<bool>("Vip")
                        .HasColumnType("tinyint(1)");

                    b.Property<double>("X")
                        .HasColumnType("double");

                    b.Property<double>("Y")
                        .HasColumnType("double");

                    b.Property<double>("Z")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}