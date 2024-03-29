﻿using Microsoft.EntityFrameworkCore;
using ScreenSound.Shared.Modelos;
using ScreenSound.Shared.Modelos.Modelos;

namespace ScreenSound.Shared.Dados
{
    public class ScreenSoundContext : DbContext
	{
        public DbSet<Artista> Artistas { get; set; }

        public DbSet<Musica> Musicas { get; set; }

        public DbSet<Genero> Generos { get; set; }

        private string connectionString = "Server=localhost,1433;Initial Catalog=ScreenSound;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;User=sa;Password=Password.1";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(connectionString)
                .UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Musica>()
            .HasMany(c => c.Generos)
            .WithMany(c => c.Musicas);
        }
    }
}

