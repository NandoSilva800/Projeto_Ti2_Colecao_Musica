﻿// <auto-generated />
using Colecao_Musica.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Colecao_Musica.Migrations
{
    [DbContext(typeof(Colecao_MusicaBD))]
    [Migration("20210624211039_labels")]
    partial class labels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
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
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<int>("ArtistasFK")
                        .HasColumnType("int");

                    b.Property<string>("Cover")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Duracao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Editora")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("GenerosFK")
                        .HasColumnType("int");

                    b.Property<int>("NrFaixas")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.HasIndex("ArtistasFK");

                    b.HasIndex("GenerosFK");

                    b.ToTable("Albuns");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ano = "1976",
                            ArtistasFK = 1,
                            Cover = "HotelCaliforniaAlbumCover.png",
                            Duracao = "43 Minutos",
                            Editora = "Asylom Records",
                            GenerosFK = 1,
                            NrFaixas = 9,
                            Titulo = "Hotel california"
                        });
                });

            modelBuilder.Entity("Colecao_Musica.Models.Artistas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nacionalidade")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserNameId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Artistas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nacionalidade = "Norte Americana",
                            Nome = "Eagles",
                            Url = "https://eagles.com/"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Designacao = "Rock"
                        },
                        new
                        {
                            Id = 2,
                            Designacao = "Pop"
                        },
                        new
                        {
                            Id = 3,
                            Designacao = "Dance"
                        },
                        new
                        {
                            Id = 4,
                            Designacao = "Classica"
                        },
                        new
                        {
                            Id = 5,
                            Designacao = "Fado"
                        },
                        new
                        {
                            Id = 6,
                            Designacao = "Ópera"
                        },
                        new
                        {
                            Id = 7,
                            Designacao = "Heavy Metal"
                        },
                        new
                        {
                            Id = 8,
                            Designacao = "Jazz"
                        });
                });

            modelBuilder.Entity("Colecao_Musica.Models.Musicas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ano")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<int>("ArtistasFK")
                        .HasColumnType("int");

                    b.Property<string>("Compositor")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Duracao")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.HasIndex("ArtistasFK");

                    b.ToTable("Musicas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ano = "1976",
                            ArtistasFK = 1,
                            Duracao = "6:31",
                            Titulo = "Hotel California"
                        });
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