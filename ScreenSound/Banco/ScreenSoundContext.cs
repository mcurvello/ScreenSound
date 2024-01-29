using Microsoft.EntityFrameworkCore;
using ScreenSound.Modelos;

namespace ScreenSound.Banco
{
    internal class ScreenSoundContext : DbContext
	{
        public DbSet<Artista> Artistas { get; set; }

        public DbSet<Musica> Musicas { get; set; }

        private string connectionString = "Server=localhost,1433;Initial Catalog=ScreenSound;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;User=sa;Password=Password.1";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(connectionString)
                .UseLazyLoadingProxies();
        }

    }
}

