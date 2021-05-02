using System;
using System.Collections.Generic;
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
        public int Duracao { get; set; }

        /// <summary>
        /// Ano em que foi editada uma musica
        /// </summary>
        public int Ano { get; set; }

        /// <summary>
        /// Nome do compositor de uma musica
        /// </summary>
        public string Compositor { get; set; }
    }
}
