﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Colecao_Musica.Models

namespace Colecao_Musica.Data
{
    /// <summary>
    /// representa a DB da colecao de musica
    /// </summary>
    public class Colecao_MusicaBD :DbContext {

        public Colecao_MusicaBD(DbContextOptions<Colecao_MusicaBD> options):base(options) {}

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
