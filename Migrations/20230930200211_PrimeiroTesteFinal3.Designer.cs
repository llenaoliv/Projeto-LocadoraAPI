﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LocadoraAPI.Migrations
{
    [DbContext(typeof(LocadoraDbContext))]
    [Migration("20230930200211_PrimeiroTesteFinal3")]
    partial class PrimeiroTesteFinal3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("LocadoraAPI.Models.Aluguel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClienteCpf")
                        .HasColumnType("TEXT");

                    b.Property<string>("PlacaVeiculo")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ClienteCpf");

                    b.HasIndex("PlacaVeiculo");

                    b.ToTable("Aluguel");
                });

            modelBuilder.Entity("LocadoraAPI.Models.Cliente", b =>
                {
                    b.Property<string>("Cpf")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Cpf");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("LocadoraAPI.Models.Veiculo", b =>
                {
                    b.Property<string>("Placa")
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Placa");

                    b.ToTable("Veiculo");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Veiculo");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("LocadoraAPI.Models.Aviao", b =>
                {
                    b.HasBaseType("LocadoraAPI.Models.Veiculo");

                    b.Property<int?>("CapacidadeDePessoas")
                        .HasColumnType("INTEGER");

                    b.ToTable("Veiculo", t =>
                        {
                            t.Property("CapacidadeDePessoas")
                                .HasColumnName("Aviao_CapacidadeDePessoas");
                        });

                    b.HasDiscriminator().HasValue("Aviao");
                });

            modelBuilder.Entity("LocadoraAPI.Models.Barco", b =>
                {
                    b.HasBaseType("LocadoraAPI.Models.Veiculo");

                    b.Property<int?>("Motores")
                        .HasColumnType("INTEGER");

                    b.HasDiscriminator().HasValue("Barco");
                });

            modelBuilder.Entity("LocadoraAPI.Models.Caminhao", b =>
                {
                    b.HasBaseType("LocadoraAPI.Models.Veiculo");

                    b.Property<int?>("CapacidadeCarga")
                        .HasColumnType("INTEGER");

                    b.HasDiscriminator().HasValue("Caminhao");
                });

            modelBuilder.Entity("LocadoraAPI.Models.Carro", b =>
                {
                    b.HasBaseType("LocadoraAPI.Models.Veiculo");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("Carro");
                });

            modelBuilder.Entity("LocadoraAPI.Models.Carroça", b =>
                {
                    b.HasBaseType("LocadoraAPI.Models.Veiculo");

                    b.Property<int?>("Cavalos")
                        .HasColumnType("INTEGER");

                    b.HasDiscriminator().HasValue("Carroça");
                });

            modelBuilder.Entity("LocadoraAPI.Models.Onibus", b =>
                {
                    b.HasBaseType("LocadoraAPI.Models.Veiculo");

                    b.Property<int?>("CapacidadeDePessoas")
                        .HasColumnType("INTEGER");

                    b.ToTable("Veiculo", t =>
                        {
                            t.Property("CapacidadeDePessoas")
                                .HasColumnName("Onibus_CapacidadeDePessoas");
                        });

                    b.HasDiscriminator().HasValue("Onibus");
                });

            modelBuilder.Entity("LocadoraAPI.Models.Van", b =>
                {
                    b.HasBaseType("LocadoraAPI.Models.Veiculo");

                    b.Property<int?>("CapacidadeDePessoas")
                        .HasColumnType("INTEGER");

                    b.HasDiscriminator().HasValue("Van");
                });

            modelBuilder.Entity("LocadoraAPI.Models.Aluguel", b =>
                {
                    b.HasOne("LocadoraAPI.Models.Cliente", "Cli")
                        .WithMany()
                        .HasForeignKey("ClienteCpf");

                    b.HasOne("LocadoraAPI.Models.Veiculo", "VeiculoAlugado")
                        .WithMany()
                        .HasForeignKey("PlacaVeiculo");

                    b.Navigation("Cli");

                    b.Navigation("VeiculoAlugado");
                });
#pragma warning restore 612, 618
        }
    }
}
