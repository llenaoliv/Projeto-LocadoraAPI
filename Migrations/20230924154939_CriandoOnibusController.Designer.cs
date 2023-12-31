﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LocadoraAPI.Migrations
{
    [DbContext(typeof(LocadoraDbContext))]
    [Migration("20230924154939_CriandoOnibusController")]
    partial class CriandoOnibusController
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("LocadoraAPI.Models.Carro", b =>
                {
                    b.Property<string>("Placa")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.HasKey("Placa");

                    b.ToTable("Carro");
                });

            modelBuilder.Entity("LocadoraAPI.Models.Onibus", b =>
                {
                    b.Property<string>("Placa")
                        .HasColumnType("TEXT");

                    b.Property<string>("CapacidadeDePessoas")
                        .HasColumnType("TEXT");

                    b.HasKey("Placa");

                    b.ToTable("Onibus");
                });
#pragma warning restore 612, 618
        }
    }
}
