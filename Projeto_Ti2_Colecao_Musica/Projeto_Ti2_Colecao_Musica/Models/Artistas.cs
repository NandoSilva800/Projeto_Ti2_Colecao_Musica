using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Ti2_Colecao_Musica.Models
{
    /// <summary>
    /// Dados de um artista
    /// </summary>
    public class Artistas
    {
        /// <summary>
        /// Construtor da classe Artistas
        /// </summary>
        public Artistas()
        {
            //aceder à BD, e selecionar todos as musicas do artista
            ListaDeMusicas = new HashSet<Musicas>();
        }

        /// <summary>
        /// Chave primária
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Nome de artista ou banda
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Nacionalidade de um artista
        /// </summary>
        public string Nacionalidade { get; set; }

        /// <summary>
        /// link da pagina de um artista
        /// </summary>
        public string url { get; set; }


        //***************************************************************
        //Criar a lista de musicas a que um artista está associado
        //***************************************************************
        public ICollection<Musicas> ListaDeMusicas { get; set; }
    }
}
