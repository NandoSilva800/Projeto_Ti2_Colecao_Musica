using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Ti2_Colecao_Musica.Models
{
    /// <summary>
    /// Dados de uma musica
    /// </summary>
    public class Musicas
    {
        /// <summary>
        /// Construtor da classe Musicas
        /// </summary>
        public Musicas()
        {
            //aceder à BD, e selecionar todos os albuns que contém a musica
            ListaDeAlbuns = new HashSet<Albuns>();
        }

        /// <summary>
        /// Chave primaria
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Titulo de uma musica
        /// </summary>
        public string Titulo { get; set; }

        /// <summary>
        /// Duração de uma musica
        /// </summary>
        public string Duracao { get; set; }

        /// <summary>
        /// Ano em que foi editada uma musica
        /// </summary>
        public string Ano { get; set; }

        /// <summary>
        /// Nome do compositor de uma musica
        /// </summary>
        public string Compositor { get; set; }

        //********************************************************************************
        //FK para Artista_Banda
        //********************************************************************************
        //Para facilitar o programador a criar os controlers as linhas seguintes
        [ForeignKey(nameof(ArtistaBanda))] //Anotador para o Entity Framework (com nome do objeto em vez do objeto)
        public int ArtistaBandaFK { get; set; }      //FK para Artista_Banda np SGBD(SQL)
        public Artistas ArtistaBanda { get; set; }     //FK para Artista_Banda no C#
        //********************************************************************************

        

        //***************************************************************
        //Criar a lista de Albuns a que uma musica está associada
        //***************************************************************
        public ICollection<Albuns> ListaDeAlbuns { get; set; }
        //***************************************************************

    }
} 
