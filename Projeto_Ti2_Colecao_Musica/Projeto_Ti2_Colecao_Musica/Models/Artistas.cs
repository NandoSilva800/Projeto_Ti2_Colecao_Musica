using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Colecao_Musica.Models
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
        /// Chave primária para os artistas
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Nome de artista ou banda
        /// </summary>
        [Required(ErrorMessage = "Preenchimento obrigatório")]
        [StringLength (30, ErrorMessage ="O {0} do artista/banda não deve ser maior que {1} caracteres.")]
        public string Nome { get; set; }

        /// <summary>
        /// Nacionalidade de um artista
        /// </summary>
        [Required(ErrorMessage = "Preenchimento obrigatório")]
        [StringLength(15, ErrorMessage = "A {0} do artista/banda não deve ter mais que {1} caracteres.")]
        public string Nacionalidade { get; set; }

        /// <summary>
        /// link da pagina de um artista
        /// </summary>
        [StringLength(70,MinimumLength = 12, ErrorMessage = "O {0} do artista/banda deve estar compreendido entre {2} e {1} caracteres.")]
        [RegularExpression("https?://(www.)?[-a-zA-Z0-9@:%._+~#=]{1,256}.[a-zA-Z0-9()]{1,6}\b([-a-zA-Z0-9()@:%_+.~#?&//=]*)", ErrorMessage = "Prencha com um link que inicie com http://www.")]
        // [Url(ErrorMessage = "Preencha um link válido")]
        public string Url { get; set; }


        //***************************************************************
        //Criar a lista de musicas a que um artista está associado
        //***************************************************************
        public ICollection<Musicas> ListaDeMusicas { get; set; }
    }
}
