using CriadoresCaes.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CriadoresCaes.Data
{
    /// <summary>
    /// Esta classe representa a Base de Dados a ser utilizada neste projeto
    /// </summary>
    public class CriadoresCaesDB : DbContext {
       /// <summary>
       /// Indicar onde está a Base de Dados à qual estas classes (tabelas) serão asssociadas 
       /// Ver o conteúdo fo ficheiro 'startup.cs'
       /// </summary>
       /// <param name="options"></param>
        public CriadoresCaesDB(DbContextOptions<CriadoresCaesDB> options):base(options)
        {

        }

        /* Representar as Tabelas da Base de Dados */
        public DbSet<Criadores> Criadores { get; set; }
        public DbSet<Caes> Caes { get; set; }
        public DbSet<Racas> Racas { get; set; }
        public DbSet<Fotografias> Fotografias { get; set; }
        public DbSet<CriadoresDeCaes> CriadoresDeCaes { get; set; }




    }
}
