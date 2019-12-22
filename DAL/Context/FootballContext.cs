using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Context
{
    public class FootballContext : DbContext
    {
        public DbSet<Match> Matches { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Stadium> Stadiums { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }

        public FootballContext(DbContextOptions<FootballContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>()
                .HasData(new Player[]
                {
                    new Player { Id = 1, TeamId = 1, FullName = "Виктор Цыганков", BornDate = new DateTime(1997,11,15), ContractDate = new DateTime(2016,08,14) },
                    new Player { Id = 2, TeamId = 1, FullName = "Миккель Дуэлунд", BornDate = new DateTime(1997,06,29), ContractDate = new DateTime(2018,08,14) },
                    new Player { Id = 3, TeamId = 1, FullName = "Жерсон Родригес", BornDate = new DateTime(1995,06,20), ContractDate = new DateTime(2019,08,02) },
                    new Player { Id = 4, TeamId = 1, FullName = "Беньямин Вербич", BornDate = new DateTime(1993,11,27), ContractDate = new DateTime(2017,12,23) },
                    new Player { Id = 5, TeamId = 1, FullName = "Денис Бойко", BornDate = new DateTime(1988,01,29), ContractDate = new DateTime(2017,12,23) },
                    new Player { Id = 6, TeamId = 2, FullName = "Тайсон Барселлос Фреда", BornDate = new DateTime(1988,01,13), ContractDate = new DateTime(2013,01,11) },
                    new Player { Id = 7, TeamId = 2, FullName = "Тете", BornDate = new DateTime(2000,02,15), ContractDate = new DateTime(2019,02,28) },
                    new Player { Id = 8, TeamId = 2, FullName = "Жуниор Мораес", BornDate = new DateTime(1987,04,04), ContractDate = new DateTime(2018,06,19) },
                    new Player { Id = 9, TeamId = 2, FullName = "Андрей Пятов", BornDate = new DateTime(1984,06,28), ContractDate = new DateTime(2006,12,13) },
                    new Player { Id = 10, TeamId = 2, FullName = "Марлос", BornDate = new DateTime(1988,06,07), ContractDate = new DateTime(2014,06,04) },

                });
            modelBuilder.Entity<Team>()
                .HasData(new Team[]
                {
                    new Team{Id = 1, City = "Киев", Name = "Динамо", CountPlayers = 5},
                    new Team{Id = 2, City = "Донецк", Name = "Шахтер", CountPlayers = 5}
                });
            modelBuilder.Entity<Stadium>()
                .HasData(new Stadium[]
                {
                    new Stadium {Id = 1, Name = "Олимпийский", City = "Киев", Capacity = 70050},
                    new Stadium {Id = 2, Name = "Донбасс Арена", City = "Донецк", Capacity = 52667}
                });
            modelBuilder.Entity<Tournament>()
                .HasData(new Tournament[]
                {
                    new Tournament { Id = 1, Name = "Украинская премьер лига", Region = "Украина", Start = new DateTime(2019,12,21), End = new DateTime(2019,12,25) }
                });
        }
    }
}
