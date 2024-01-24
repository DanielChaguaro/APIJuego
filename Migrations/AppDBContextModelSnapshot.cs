﻿// <auto-generated />
using System;
using APIJuego.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APIJuego.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("APIJuego.Models.Juego", b =>
                {
                    b.Property<int>("IdJuego")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdJuego"));

                    b.Property<DateTime>("fechaganada")
                        .HasColumnType("datetime2");

                    b.HasKey("IdJuego");

                    b.ToTable("fechasganada");

                    b.HasData(
                        new
                        {
                            IdJuego = 1,
                            fechaganada = new DateTime(2024, 1, 24, 9, 6, 11, 945, DateTimeKind.Local).AddTicks(6591)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
