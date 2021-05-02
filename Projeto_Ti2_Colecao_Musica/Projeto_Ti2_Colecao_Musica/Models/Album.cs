using System;
using System.Collections.Generic;
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
        /// Genero de musica do album
        /// </summary>
        public string Genero { get; set; }
    }
}
