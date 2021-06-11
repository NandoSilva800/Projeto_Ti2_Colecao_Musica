﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Colecao_Musica.Models
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
        /// Chave primaria para as musicas
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Titulo de uma musica
        /// </summary>
        [Required(ErrorMessage ="Preenchimento obrigatório")]
        [StringLength(25, ErrorMessage = "O {0} não deve ter mais que {1} caracteres.")]
        public string Titulo { get; set; }

        /// <summary>
        /// Duração de uma musica
        /// </summary>
        [Required(ErrorMessage = "Preenchimento obrigatório")]
        [StringLength(15, ErrorMessage = "A {0} não deve ter mais que {1} caracteres.")]
        public string Duracao { get; set; }

        /// <summary>
        /// Ano em que foi editada uma musica
        /// </summary>
        [Required(ErrorMessage = "Preenchimento obrigatório")]
        [StringLength(4, MinimumLength = 4 , ErrorMessage = "O {0} deve conter {1} caracteres.")]
        public string Ano { get; set; }

        /// <summary>
        /// Nome do compositor de uma musica
        /// </summary>
        [StringLength(25, ErrorMessage = "O {0} não deve ter mais que {1} caracteres.")]
        public string Compositor { get; set; }

        //********************************************************************************
        //FK para Artistas
        //********************************************************************************
        //Para facilitar o programador a criar os controlers as linhas seguintes
        [ForeignKey(nameof(Artista))] //Anotador para o Entity Framework (com nome do objeto em vez do objeto)
        public int ArtistasFK { get; set; }      //FK para Artistas np SGBD(SQL)
        public Artistas Artista { get; set; }     //FK para Artistas no C#
        //********************************************************************************

        

        //*******************************************************************************
        //Criar a lista de Albuns a que uma musica está associada
        //*******************************************************************************
        public ICollection<Albuns> ListaDeAlbuns { get; set; }
        //*******************************************************************************

    }
} 
