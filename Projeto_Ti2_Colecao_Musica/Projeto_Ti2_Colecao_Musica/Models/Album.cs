using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Ti2_Colecao_Musica.Models
{
    /// <summary>
    /// Dados de um album
    /// </summary>
    public class Album
    {
        /// <summary>
        /// Construtor da classe Album
        /// </summary>
        public Album()
        {
            //aceder à BD, e selecionar todos as musicas do album
            ListaDeMusicas = new HashSet<Musica>();
        }

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


        //*******************************************************************
        //FK para o Genero
        //*******************************************************************
        //Para facilitar o programador a criar os controlers as linhas seguintes
        [ForeignKey(nameof(Genero))] //Anotador para o Entity Framework (com nome do objeto em vez do objeto
        public  int GeneroFK { get; set; }      //FK para Genero np SGBD(SQL)
        
        public Genero Genero { get; set; }     //FK para Genero no C#
                                               //*******************************************************************


        //***************************************************************
        //Criar a lista de Musicas a que um Album está associado
        //***************************************************************
        public ICollection<Musica> ListaDeMusicas { get; set; }
    }
}
