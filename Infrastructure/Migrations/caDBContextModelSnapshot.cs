﻿// <auto-generated />
using System;
using Infrastructure.Database.MySQLDatabase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(caDBContext))]
    partial class caDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Models.Bird", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("CanFly")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Birds");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ec351eb4-fdb8-42fb-ba13-ea797b4cce17"),
                            CanFly = true,
                            Name = "Robin"
                        },
                        new
                        {
                            Id = new Guid("2ce18000-396d-41cb-955f-770b7940fe78"),
                            CanFly = true,
                            Name = "Sparrow"
                        },
                        new
                        {
                            Id = new Guid("84bedb48-16cd-4829-99bd-dc888b476c97"),
                            CanFly = true,
                            Name = "Birdy"
                        },
                        new
                        {
                            Id = new Guid("1ef3c1f4-a313-4448-b3e5-aadf55b3d7f5"),
                            CanFly = false,
                            Name = "Herdy"
                        },
                        new
                        {
                            Id = new Guid("c529eead-435c-4a3f-a8f5-a3639fc9be65"),
                            CanFly = true,
                            Name = "Gerdy"
                        });
                });

            modelBuilder.Entity("Domain.Models.Cat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("LikesToPlay")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Cats");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d30ae68e-5bed-4b73-9527-30f6378989da"),
                            LikesToPlay = true,
                            Name = "Fluffy"
                        },
                        new
                        {
                            Id = new Guid("5886fa40-a54e-4c8d-8612-48cf983b2bde"),
                            LikesToPlay = false,
                            Name = "Whiskers"
                        },
                        new
                        {
                            Id = new Guid("9dd335d5-a8d4-44b9-96e9-cd35d35d0f69"),
                            LikesToPlay = false,
                            Name = "Lickers"
                        },
                        new
                        {
                            Id = new Guid("f840a52f-207c-4741-9f3f-f3bfac0c4cf4"),
                            LikesToPlay = true,
                            Name = "Sickers"
                        },
                        new
                        {
                            Id = new Guid("282136bf-ed11-4eaa-95ac-5fe8e2ecd7f8"),
                            LikesToPlay = false,
                            Name = "Fluffers"
                        });
                });

            modelBuilder.Entity("Domain.Models.Dog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("LikesToPlay")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Dogs");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c555e635-f270-4ea9-a1a7-86486bf48176"),
                            LikesToPlay = false,
                            Name = "PeppeLeDog"
                        },
                        new
                        {
                            Id = new Guid("dae7919a-9e55-4484-a567-31edd78379e7"),
                            LikesToPlay = false,
                            Name = "Fofi"
                        },
                        new
                        {
                            Id = new Guid("804577a8-7271-4fa3-96db-62d287dd42ac"),
                            LikesToPlay = false,
                            Name = "Simo"
                        },
                        new
                        {
                            Id = new Guid("3344e313-83f8-49c5-8c3f-0176cd5bfdb9"),
                            LikesToPlay = false,
                            Name = "Lano"
                        });
                });

            modelBuilder.Entity("Domain.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
