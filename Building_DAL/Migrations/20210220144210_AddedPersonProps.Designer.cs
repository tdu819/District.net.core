﻿// <auto-generated />
using System;
using District.Dal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace District.Dal.Migrations
{
    [DbContext(typeof(DistrictDbCondext))]
    [Migration("20210220144210_AddedPersonProps")]
    partial class AddedPersonProps
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("District.Entities.Tables.Apartment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ApartmentNumber")
                        .HasColumnType("integer");

                    b.Property<int>("BuildingId")
                        .HasColumnType("integer");

                    b.Property<int>("EntranceId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsOwn")
                        .HasColumnType("boolean");

                    b.Property<int>("PersonId")
                        .HasColumnType("integer");

                    b.Property<int>("SquareSize")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("BuildingId");

                    b.HasIndex("EntranceId");

                    b.HasIndex("PersonId");

                    b.ToTable("Apartments");
                });

            modelBuilder.Entity("District.Entities.Tables.Building", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("BuildingNumber")
                        .HasColumnType("integer");

                    b.Property<string>("Street")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Buildings");
                });

            modelBuilder.Entity("District.Entities.Tables.Entrance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("BuildingId")
                        .HasColumnType("integer");

                    b.Property<int>("EntranceNumer")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("BuildingId");

                    b.ToTable("Entrances");
                });

            modelBuilder.Entity("District.Entities.Tables.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("District.Entities.Tables.Apartment", b =>
                {
                    b.HasOne("District.Entities.Tables.Building", "Building")
                        .WithMany()
                        .HasForeignKey("BuildingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("District.Entities.Tables.Entrance", "Entrance")
                        .WithMany()
                        .HasForeignKey("EntranceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("District.Entities.Tables.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Building");

                    b.Navigation("Entrance");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("District.Entities.Tables.Entrance", b =>
                {
                    b.HasOne("District.Entities.Tables.Building", "Building")
                        .WithMany()
                        .HasForeignKey("BuildingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Building");
                });
#pragma warning restore 612, 618
        }
    }
}
