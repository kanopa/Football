using DAL.Context;
using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class MatchRepository : IMatchRepository
    {
        private FootballContext db;
        public MatchRepository(FootballContext db)
        {
            this.db = db;
        }
        public async Task<Match> AddMatch(Match match)
        {
            var newMatch = await db.Matches.AddAsync(match);
            await db.SaveChangesAsync();
            return newMatch.Entity;
        }

        public async Task<ICollection<Match>> GetMatch()
        {
            return await db.Matches.ToListAsync();
        }
    }
}
