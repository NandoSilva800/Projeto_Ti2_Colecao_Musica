using Microsoft.EntityFrameworkCore;
using Colecao_Musica.Models;

namespace Colecao_Musica.Data
{
    /// <summary>
    /// representa a DB da colecao de musica
    /// </summary>
    public class Colecao_MusicaBD :DbContext {

        //onde está guardada a BD --> appsettings.json
        // tipo da BD ---->    startup.cs

        public Colecao_MusicaBD(DbContextOptions<Colecao_MusicaBD> options):base(options) {}


        /// <summary>
        /// Método para assistir a criaçºao da BD que representa o modelo
        /// </summary>
        /// <param name="modelBuilder">opção de configuração da criação do modelo</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // importa todo o comportamento deste método
            //Definido na classe DbContext
            base.OnModelCreating(modelBuilder);

            //********************************************************


            //Acrescentar novas tarefas...
            //********************************************************

            //Adicionar dados às tabelas da BD
            //modelBuilder.Entity<Generos>().HasData(
                // new Generos { Id =1, Designacao= "Rock"}
                //);

        }

        //*********************************************
        //especificar as tabelas na BD
        //*********************************************
        public DbSet<Musicas> Musicas { get; set; }
        public DbSet<Albuns> Albuns { get; set; }
        public DbSet<Artistas> Artistas { get; set; }
        public DbSet<Generos> Generos { get; set; }
        //*********************************************
    }

}
