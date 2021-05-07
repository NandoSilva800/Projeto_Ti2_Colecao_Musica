using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Ti2_Colecao_Musica.Models
{
    /// <summary>
    /// Dados de uma musica
    /// </summary>
    public class Musica
    {
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
        [ForeignKey(nameof(Artista_Banda))] //Anotador para o Entity Framework (com nome do objeto em vez do objeto)
        public int Artista_BandaFK { get; set; }      //FK para Artista_Banda np SGBD(SQL)

        public Artista_Banda Artista_Banda { get; set; }     //FK para Artista_Banda no C#
        //********************************************************************************

        //********************************************************************************
        //FK para Album
        //********************************************************************************
        //Para facilitar o programador a criar os controlers as linhas seguintes
        [ForeignKey(nameof(Album))] //Anotador para o Entity Framework (com nome do objeto em vez do objeto)
        public int AlbumFK { get; set; }      //FK para Album np SGBD(SQL)

        public Album Album { get; set; }     //FK para Album no C#
        //********************************************************************************


    }
}
