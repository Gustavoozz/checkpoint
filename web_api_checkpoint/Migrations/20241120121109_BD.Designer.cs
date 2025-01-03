﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using web_api_checkpoint.Contexts;

#nullable disable

namespace web_api_checkpoint.Migrations
{
    [DbContext(typeof(CheckpointContext))]
    [Migration("20241120121109_BD")]
    partial class BD
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("web_api_checkpoint.Domains.CalendarioLetivo", b =>
                {
                    b.Property<Guid>("IdCalendarioLetivo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Data")
                        .HasColumnType("DATE");

                    b.Property<bool>("IsDiaLetivo")
                        .HasColumnType("BIT");

                    b.HasKey("IdCalendarioLetivo");

                    b.HasIndex("Data")
                        .IsUnique();

                    b.ToTable("CalendarioLetivo");
                });

            modelBuilder.Entity("web_api_checkpoint.Domains.Estagiario", b =>
                {
                    b.Property<Guid>("IdEstagiario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdExpediente")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdSquad")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdUsuario")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsBolsista")
                        .HasColumnType("BIT");

                    b.Property<string>("Matrícula")
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("IdEstagiario");

                    b.HasIndex("IdExpediente");

                    b.HasIndex("IdSquad");

                    b.HasIndex("IdUsuario");

                    b.HasIndex("Matrícula")
                        .IsUnique()
                        .HasFilter("[Matrícula] IS NOT NULL");

                    b.ToTable("Estagiario");
                });

            modelBuilder.Entity("web_api_checkpoint.Domains.Expediente", b =>
                {
                    b.Property<Guid>("IdExpediente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<TimeOnly>("FimExpediente")
                        .HasColumnType("TIME");

                    b.Property<TimeOnly>("InicioExpediente")
                        .HasColumnType("TIME");

                    b.HasKey("IdExpediente");

                    b.ToTable("Expediente");
                });

            modelBuilder.Entity("web_api_checkpoint.Domains.JustificativaFalta", b =>
                {
                    b.Property<Guid>("IdJustificativaFalta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdMidia")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdPresenca")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MotivoRejeicao")
                        .HasColumnType("TEXT");

                    b.Property<int>("StatusValidacao")
                        .HasColumnType("INT");

                    b.Property<bool>("ValidadoPorIA")
                        .HasColumnType("BIT");

                    b.HasKey("IdJustificativaFalta");

                    b.HasIndex("IdMidia");

                    b.HasIndex("IdPresenca");

                    b.HasIndex("StatusValidacao")
                        .IsUnique();

                    b.ToTable("JustificativaFalta");
                });

            modelBuilder.Entity("web_api_checkpoint.Domains.Midia", b =>
                {
                    b.Property<Guid>("IdMidia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BlobStorageName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("IdMidia");

                    b.ToTable("Midia");
                });

            modelBuilder.Entity("web_api_checkpoint.Domains.Presenca", b =>
                {
                    b.Property<Guid>("IdPresenca")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<TimeOnly?>("HorarioEntrada")
                        .HasColumnType("TIME");

                    b.Property<TimeOnly?>("HorarioSaida")
                        .HasColumnType("TIME");

                    b.Property<Guid?>("IdCalendarioLetivo")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdEstagiario")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdPresenca");

                    b.HasIndex("IdCalendarioLetivo");

                    b.HasIndex("IdEstagiario");

                    b.ToTable("Presenca");
                });

            modelBuilder.Entity("web_api_checkpoint.Domains.Squad", b =>
                {
                    b.Property<Guid>("IdSquad")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("BIT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("IdSquad");

                    b.ToTable("Squad");
                });

            modelBuilder.Entity("web_api_checkpoint.Domains.SquadGestor", b =>
                {
                    b.Property<Guid>("IdSquadGestor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdSquad")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdUsuario")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdSquadGestor");

                    b.HasIndex("IdSquad");

                    b.HasIndex("IdUsuario");

                    b.ToTable("SquadGestor");
                });

            modelBuilder.Entity("web_api_checkpoint.Domains.Tarefa", b =>
                {
                    b.Property<Guid>("IdTarefa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<string>("DescricaoCorrecao")
                        .HasColumnType("TEXT");

                    b.Property<int>("Dificuldade")
                        .HasColumnType("INT");

                    b.Property<Guid?>("IdEstagiario")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Prazo")
                        .HasColumnType("DATE");

                    b.Property<int>("StatusCorrecao")
                        .HasColumnType("INT");

                    b.Property<string>("Titulo")
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("IdTarefa");

                    b.HasIndex("IdEstagiario");

                    b.ToTable("Tarefa");
                });

            modelBuilder.Entity("web_api_checkpoint.Domains.TarefaEstagiarioMidia", b =>
                {
                    b.Property<Guid>("IdTarefaEstagiarioMidia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdMidia")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdTarefa")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdTarefaEstagiarioMidia");

                    b.HasIndex("IdMidia");

                    b.HasIndex("IdTarefa");

                    b.ToTable("TarefaEstagiarioMidia");
                });

            modelBuilder.Entity("web_api_checkpoint.Domains.TarefaMidia", b =>
                {
                    b.Property<Guid>("IdTarefaMidia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdMidia")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdTarefa")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdTarefaMidia");

                    b.HasIndex("IdMidia");

                    b.HasIndex("IdTarefa");

                    b.ToTable("TarefaMidia");
                });

            modelBuilder.Entity("web_api_checkpoint.Domains.Usuario", b =>
                {
                    b.Property<Guid>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CodigoRecSenha")
                        .HasColumnType("NCHAR(6)");

                    b.Property<string>("EmailCorporativo")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("EmailPessoal")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("BIT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<int>("Role")
                        .HasColumnType("INT");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<string>("SobreNome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("IdUsuario");

                    b.HasIndex("EmailCorporativo", "EmailPessoal")
                        .IsUnique();

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("web_api_checkpoint.Domains.Estagiario", b =>
                {
                    b.HasOne("web_api_checkpoint.Domains.Expediente", "Expediente")
                        .WithMany()
                        .HasForeignKey("IdExpediente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("web_api_checkpoint.Domains.Squad", "Squad")
                        .WithMany()
                        .HasForeignKey("IdSquad");

                    b.HasOne("web_api_checkpoint.Domains.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario");

                    b.Navigation("Expediente");

                    b.Navigation("Squad");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("web_api_checkpoint.Domains.JustificativaFalta", b =>
                {
                    b.HasOne("web_api_checkpoint.Domains.Midia", "Midia")
                        .WithMany()
                        .HasForeignKey("IdMidia");

                    b.HasOne("web_api_checkpoint.Domains.Presenca", "Presenca")
                        .WithMany()
                        .HasForeignKey("IdPresenca");

                    b.Navigation("Midia");

                    b.Navigation("Presenca");
                });

            modelBuilder.Entity("web_api_checkpoint.Domains.Presenca", b =>
                {
                    b.HasOne("web_api_checkpoint.Domains.CalendarioLetivo", "CalendarioLetivo")
                        .WithMany()
                        .HasForeignKey("IdCalendarioLetivo");

                    b.HasOne("web_api_checkpoint.Domains.Estagiario", "Estagiario")
                        .WithMany()
                        .HasForeignKey("IdEstagiario");

                    b.Navigation("CalendarioLetivo");

                    b.Navigation("Estagiario");
                });

            modelBuilder.Entity("web_api_checkpoint.Domains.SquadGestor", b =>
                {
                    b.HasOne("web_api_checkpoint.Domains.Squad", "Squad")
                        .WithMany()
                        .HasForeignKey("IdSquad");

                    b.HasOne("web_api_checkpoint.Domains.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario");

                    b.Navigation("Squad");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("web_api_checkpoint.Domains.Tarefa", b =>
                {
                    b.HasOne("web_api_checkpoint.Domains.Estagiario", "Estagiario")
                        .WithMany()
                        .HasForeignKey("IdEstagiario");

                    b.Navigation("Estagiario");
                });

            modelBuilder.Entity("web_api_checkpoint.Domains.TarefaEstagiarioMidia", b =>
                {
                    b.HasOne("web_api_checkpoint.Domains.Midia", "Midia")
                        .WithMany()
                        .HasForeignKey("IdMidia");

                    b.HasOne("web_api_checkpoint.Domains.Tarefa", "Tarefa")
                        .WithMany()
                        .HasForeignKey("IdTarefa");

                    b.Navigation("Midia");

                    b.Navigation("Tarefa");
                });

            modelBuilder.Entity("web_api_checkpoint.Domains.TarefaMidia", b =>
                {
                    b.HasOne("web_api_checkpoint.Domains.Midia", "Midia")
                        .WithMany()
                        .HasForeignKey("IdMidia");

                    b.HasOne("web_api_checkpoint.Domains.Tarefa", "Tarefa")
                        .WithMany()
                        .HasForeignKey("IdTarefa");

                    b.Navigation("Midia");

                    b.Navigation("Tarefa");
                });
#pragma warning restore 612, 618
        }
    }
}
