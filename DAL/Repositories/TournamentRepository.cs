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
    public class TournamentRepository : ITournamentRepository
    {
        private FootballContext db;
        public TournamentRepository(FootballContext db)
        {
            this.db = db;
        }
        public async Task<ICollection<Tournament>> GetTournament()
        {
            return await db.Tournaments.ToListAsync();
        }
    }
}
