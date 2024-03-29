﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using User.Models;

#nullable disable

namespace User.Migrations
{
    [DbContext(typeof(UserDbContext))]
    partial class UserDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("User.Models.BankAccounts", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Balance")
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Numbers")
                        .HasColumnType("varchar(30)");

                    b.Property<Guid>("UsersId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("UsersId");

                    b.ToTable("BankAccount");
                });

            modelBuilder.Entity("User.Models.Users", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("User.Models.BankAccounts", b =>
                {
                    b.HasOne("User.Models.Users", "Users")
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
