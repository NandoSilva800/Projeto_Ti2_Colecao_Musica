﻿// <auto-generated />
using Colecao_Musica.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Colecao_Musica.Migrations
{
    [DbContext(typeof(Colecao_MusicaBD))]
    partial class Colecao_MusicaBDModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AlbunsMusicas", b =>
                {
                    b.Property<int>("ListaDeAlbunsId")
                        .HasColumnType("int");

                    b.Property<int>("ListaDeMusicasId")
                        .HasColumnType("int");

                    b.HasKey("ListaDeAlbunsId", "ListaDeMusicasId");

                    b.HasIndex("ListaDeMusicasId");

                    b.ToTable("AlbunsMusicas");
                });

            modelBuilder.Entity("Colecao_Musica.Models.Albuns", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ano")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ArtistasFK")
                        .HasColumnType("int");

                    b.Property<string>("Cover")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Duracao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Editora")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenerosFK")
                        .HasColumnType("int");

                    b.Property<int>("NrFaixas")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ArtistasFK");

                    b.HasIndex("GenerosFK");

                    b.ToTable("Albuns");
                });

            modelBuilder.Entity("Colecao_Musica.Models.Artistas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nacionalidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Artistas");
                });

            modelBuilder.Entity("Colecao_Musica.Models.Generos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Designacao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("Colecao_Musica.Models.Musicas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ano")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ArtistasFK")
                        .HasColumnType("int");

                    b.Property<string>("Compositor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Duracao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ArtistasFK");

                    b.ToTable("Musicas");
                });

            modelBuilder.Entity("AlbunsMusicas", b =>
                {
                    b.HasOne("Colecao_Musica.Models.Albuns", null)
                        .WithMany()
                        .HasForeignKey("ListaDeAlbunsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Colecao_Musica.Models.Musicas", null)
                        .WithMany()
                        .HasForeignKey("ListaDeMusicasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Colecao_Musica.Models.Albuns", b =>
                {
                    b.HasOne("Colecao_Musica.Models.Artistas", "Artista")
                        .WithMany()
                        .HasForeignKey("ArtistasFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Colecao_Musica.Models.Generos", "Genero")
                        .WithMany("ListaDeAlbuns")
                        .HasForeignKey("GenerosFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artista");

                    b.Navigation("Genero");
                });

            modelBuilder.Entity("Colecao_Musica.Models.Musicas", b =>
                {
                    b.HasOne("Colecao_Musica.Models.Artistas", "Artista")
                        .WithMany("ListaDeMusicas")
                        .HasForeignKey("ArtistasFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artista");
                });

            modelBuilder.Entity("Colecao_Musica.Models.Artistas", b =>
                {
                    b.Navigation("ListaDeMusicas");
                });

            modelBuilder.Entity("Colecao_Musica.Models.Generos", b =>
                {
                    b.Navigation("ListaDeAlbuns");
                });
#pragma warning restore 612, 618
        }
    }
}
