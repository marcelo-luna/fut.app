using geradorTimes.Models;
using System.Data.Entity;
using System.Reflection.Emit;
using System.Configuration;

namespace geradorTimes.DAO
{
    public class GeradorContext : DbContext
    {
        public DbSet<Jogador> Jogadores { get; set; }

        public DbSet<Time> Times { get; set; }

        /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Jogador>().HasRequired(j => j.Time);
        }*/
    }
}