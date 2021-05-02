using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Ti2_Colecao_Musica.Models
{
    /// <summary>
    /// Dados de um artista ou de uma banda de música
    /// </summary>
    public class Artista_Banda
    {
        /// <summary>
        /// Nome de artista ou banda
        /// </summary>
        public string Nome { get; set; }
        
        /// <summary>
        /// Nacionalidade de um artista ou banda
        /// </summary>
        public string Nacionalidade { get; set; }

        /// <summary>
        /// link da pagina de um artista ou banda
        /// </summary>
        public string url { get; set; }
    }
}
