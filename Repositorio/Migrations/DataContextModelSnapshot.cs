﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repositorio;

namespace Repositorio.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Dominio.AtendimentoModel.Atendimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AssociadoId")
                        .HasColumnType("int");

                    b.Property<int>("CidadeId")
                        .HasColumnType("int");

                    b.Property<int>("ConveniadoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataHorarioAgendamento")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("PrestadorId")
                        .HasColumnType("int");

                    b.Property<int>("StatusProcesso")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("AssociadoId");

                    b.HasIndex("CidadeId");

                    b.HasIndex("ConveniadoId");

                    b.HasIndex("PrestadorId");

                    b.ToTable("Atendimento");
                });

            modelBuilder.Entity("Dominio.GeotecnologiaModel.Cidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CodigoEstado")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Cidade");
                });

            modelBuilder.Entity("Dominio.PlanoModel.CategoriaPlano", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("CategoriaPlano");
                });

            modelBuilder.Entity("Dominio.PlanoModel.Plano", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoriaPlanoId")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<decimal>("PorcentagemDesconto")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("TipoPlanoId")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorBase")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaPlanoId");

                    b.HasIndex("TipoPlanoId");

                    b.ToTable("Plano");
                });

            modelBuilder.Entity("Dominio.PlanoModel.TipoPlano", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("TipoPlano");
                });

            modelBuilder.Entity("Dominio.UsuarioModel.Associado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("PlanoId")
                        .HasColumnType("int");

                    b.Property<bool>("PossuiOdontologico")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("QuantidadeExamesAno")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorPlanoAdicional")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("PlanoId");

                    b.ToTable("Associado");
                });

            modelBuilder.Entity("Dominio.UsuarioModel.Conveniado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cnpj")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("NomeFantasia")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Conveniado");
                });

            modelBuilder.Entity("Dominio.UsuarioModel.ConveniadoPrestador", b =>
                {
                    b.Property<int>("ConveniadoId")
                        .HasColumnType("int");

                    b.Property<int>("PrestadorId")
                        .HasColumnType("int");

                    b.HasKey("ConveniadoId", "PrestadorId");

                    b.HasIndex("PrestadorId");

                    b.ToTable("ConveniadoPrestador");
                });

            modelBuilder.Entity("Dominio.UsuarioModel.Prestador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CRM")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Prestador");
                });

            modelBuilder.Entity("Dominio.AtendimentoModel.Atendimento", b =>
                {
                    b.HasOne("Dominio.UsuarioModel.Associado", "Associado")
                        .WithMany("Atendimentos")
                        .HasForeignKey("AssociadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.GeotecnologiaModel.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.UsuarioModel.Conveniado", "Conveniado")
                        .WithMany("Atendimentos")
                        .HasForeignKey("ConveniadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.UsuarioModel.Prestador", "Prestador")
                        .WithMany("Atendimentos")
                        .HasForeignKey("PrestadorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Dominio.PlanoModel.Plano", b =>
                {
                    b.HasOne("Dominio.PlanoModel.CategoriaPlano", "CategoriaPlano")
                        .WithMany("Planos")
                        .HasForeignKey("CategoriaPlanoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.PlanoModel.TipoPlano", "TipoPlano")
                        .WithMany("Planos")
                        .HasForeignKey("TipoPlanoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Dominio.UsuarioModel.Associado", b =>
                {
                    b.HasOne("Dominio.PlanoModel.Plano", "Plano")
                        .WithMany("Associados")
                        .HasForeignKey("PlanoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Dominio.UsuarioModel.ConveniadoPrestador", b =>
                {
                    b.HasOne("Dominio.UsuarioModel.Conveniado", "Conveniado")
                        .WithMany("ConveniadosPrestadores")
                        .HasForeignKey("ConveniadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.UsuarioModel.Prestador", "Prestador")
                        .WithMany("ConveniadosPrestadores")
                        .HasForeignKey("PrestadorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
