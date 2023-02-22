﻿// <auto-generated />
using System;
using Backend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Backend.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    partial class ApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Backend.Models.AutorModel", b =>
                {
                    b.Property<int>("IdAutor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAutor"), 1L, 1);

                    b.Property<int>("LivroID")
                        .HasColumnType("int");

                    b.Property<string>("NomeAutor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdAutor");

                    b.HasIndex("LivroID");

                    b.ToTable("Autores");
                });

            modelBuilder.Entity("Backend.Models.LivroModel", b =>
                {
                    b.Property<int>("IdLivro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdLivro"), 1L, 1);

                    b.Property<DateTime>("DataPublicacao")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Edicao")
                        .HasColumnType("int");

                    b.Property<string>("Editora")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("QuantLivros")
                        .HasColumnType("int");

                    b.Property<int>("QuantPaginas")
                        .HasColumnType("int");

                    b.Property<string>("Resumo")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Subtitulo")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdLivro");

                    b.ToTable("Livros");
                });

            modelBuilder.Entity("Backend.Models.AutorModel", b =>
                {
                    b.HasOne("Backend.Models.LivroModel", "Livro")
                        .WithMany("Autores")
                        .HasForeignKey("LivroID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Livro");
                });

            modelBuilder.Entity("Backend.Models.LivroModel", b =>
                {
                    b.Navigation("Autores");
                });
#pragma warning restore 612, 618
        }
    }
}
