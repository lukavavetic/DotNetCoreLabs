﻿// <auto-generated />
using System;
using DotNetCoreLabs.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DotNetCoreLabs.Data.Migrations
{
    [DbContext(typeof(DotNetCoreLabsContext))]
    partial class DotNetCoreLabsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("DotNetCoreLabs.Data.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("Email");

                    b.Property<string>("Firstname");

                    b.Property<string>("Lastname");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(1994, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "luka.vavetic@gmail.com",
                            Firstname = "Luka",
                            Lastname = "Vavetić",
                            Username = "Lukaku"
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(1989, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "frano.sasavi@gmail.com",
                            Firstname = "Frano",
                            Lastname = "Sasvari",
                            Username = "Fusari"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
