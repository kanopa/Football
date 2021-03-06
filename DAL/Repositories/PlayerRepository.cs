﻿using DAL.Context;
using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private FootballContext db;
        public PlayerRepository(FootballContext db)
        {
            this.db = db;
        }

        public async Task<Player> AddPlayer(Player player)
        {
            var newPlayer = await db.Players.AddAsync(player);
            await db.SaveChangesAsync();
            return newPlayer.Entity;
        }

        public async Task<ICollection<Player>> GetPlayers()
        {
            return await db.Players.ToListAsync();
        }
    }
}
