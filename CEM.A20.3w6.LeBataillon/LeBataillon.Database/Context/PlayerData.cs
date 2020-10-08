using System.Collections.Generic;
using LeBataillon.Database.Initializer.DataFixtures;
using LeBataillon.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace LeBataillon.Database.Context
{
    public class PlayerData : DbContext
    {
        public PlayerData(DbContextOptions<PlayerData> options) : base(options)
        {

        }
        public DbSet<Game> Games { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();

        }

        public List<Player> Data = new List<Player>();

        public void EnsureCreated()
        {

            for (int i = 1; i < 100; i++)
            {
                var name = SampleData.GenerateName(i);
                Data.Add(new Player(i, $"{name}Alias", $"{name}@bataillonMail.com", SampleData.GeneratePhoneNumber(i), SampleData.GenerateName(i + 1), SampleData.GenerateLastName(i), SampleData.GenerateLevel()));
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }



}
