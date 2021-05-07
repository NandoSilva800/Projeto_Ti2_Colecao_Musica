using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Ti2_Colecao_Musica.Models
{   
    /// <summary>
    /// Identifica os géneros de uma música
    /// </summary>
    public class Genero
    {
        /// <summary>
        /// Construtor da classe Genero
        /// </summary>
        public Genero()
        {
            //aceder à BD, e selecionar todos os albuns do genero
            ListaDeAlbuns = new HashSet<Album>();
        }

        /// <summary>
        /// nome do genero de musica
        /// </summary>
        public string Designacao { get; set; }

        //***************************************************************
        //Criar a lista de Albuns a que um Genero está associada
        //***************************************************************
        public ICollection <Album> ListaDeAlbuns{ get; set; }

    }
}
