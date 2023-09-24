﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using bookStore.Data;

#nullable disable

namespace bookStore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230920163821_nomesVariaveisUpdate2")]
    partial class nomesVariaveisUpdate2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("bookStore.Models.Editora", b =>
                {
                    b.Property<int>("EditoraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EditoraId"));

                    b.Property<int>("AnoFundacao")
                        .HasColumnType("int");

                    b.Property<string>("NomeEditora")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slogan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URLLogo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EditoraId");

                    b.ToTable("Editoras");
                });

            modelBuilder.Entity("bookStore.Models.Escritor", b =>
                {
                    b.Property<int>("EscritorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EscritorId"));

                    b.Property<string>("Biografia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeCompleto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URLFoto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EscritorId");

                    b.ToTable("Escritores");
                });

            modelBuilder.Entity("bookStore.Models.Livro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DataLancamento")
                        .HasColumnType("int");

                    b.Property<int>("EditoraId")
                        .HasColumnType("int");

                    b.Property<int>("EscritorId")
                        .HasColumnType("int");

                    b.Property<int>("LivroCategora")
                        .HasColumnType("int");

                    b.Property<double>("Preco")
                        .HasColumnType("float");

                    b.Property<string>("Sinopse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URlImagem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EditoraId");

                    b.HasIndex("EscritorId");

                    b.ToTable("Livros");
                });

            modelBuilder.Entity("bookStore.Models.Livro", b =>
                {
                    b.HasOne("bookStore.Models.Editora", "Editora")
                        .WithMany("Livros")
                        .HasForeignKey("EditoraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("bookStore.Models.Escritor", "Escritor")
                        .WithMany("Livros")
                        .HasForeignKey("EscritorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Editora");

                    b.Navigation("Escritor");
                });

            modelBuilder.Entity("bookStore.Models.Editora", b =>
                {
                    b.Navigation("Livros");
                });

            modelBuilder.Entity("bookStore.Models.Escritor", b =>
                {
                    b.Navigation("Livros");
                });
#pragma warning restore 612, 618
        }
    }
}