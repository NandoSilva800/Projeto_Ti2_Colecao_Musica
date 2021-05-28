﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Colecao_Musica.Models
{
    /// <summary>
    /// Dados de um album
    /// </summary>
    public class Albuns
    {
        /// <summary>
        /// Construtor da classe Album
        /// </summary>
        public Albuns()
        {
            //aceder à BD, e selecionar todos as musicas do album
            ListaDeMusicas = new HashSet<Musicas>();
        }
        /// <summary>
        /// Chave primaria
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Titulo de um album
        /// </summary>
        public string Titulo { get; set; }

        /// <summary>
        /// Duração total de um album
        /// </summary>
        public string Duracao { get; set; }

        /// <summary>
        /// Numero total de faixas de um album
        /// </summary>
        public int NrFaixas { get; set; }

        /// <summary>
        /// Ano em que foi editado o album
        /// </summary>
        public string Ano { get; set; }

        /// <summary>
        /// Nome da editora que editou o album
        /// </summary>
        public string Editora { get; set; }

        /// <summary>
        /// Imagem referente a capa do album
        /// </summary>
        public string Cover { get; set; }



        //************************************************************************
        //FK para Generos
        //************************************************************************
        //Para facilitar o programador a criar os controlers as linhas seguintes
        [ForeignKey(nameof(Genero))] //Anotador para o Entity Framework (com nome do objeto em vez do objeto
        public  int GenerosFK { get; set; }      //FK para Generos np SGBD(SQL) 
        public Generos Genero { get; set; }     //FK para Generos no C#
        
        
        //***********************************************************************
        //FK para Artistas
        //***********************************************************************
        //Para facilitar o programador a criar os controlers as linhas seguintes
        [ForeignKey(nameof(Artista))] //Anotador para o Entity Framework (com nome do objeto em vez do objeto)
        public int ArtistasFK { get; set; }      //FK para Artistas np SGBD(SQL)
        public Artistas Artista { get; set; }    //FK para Artistas no C#


        //**********************************************************************
        //Criar a lista de Musicas a que um Album está associado
        //**********************************************************************
        public ICollection<Musicas> ListaDeMusicas { get; set; }
    }
}
