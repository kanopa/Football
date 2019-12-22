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
    public class TeamRepository : ITeamRepository
    {
        private FootballContext db;
        public TeamRepository(FootballContext db)
        {
            this.db = db;
        }
        public async Task<ICollection<Team>> GetTeams()
        {
            return await db.Teams.ToListAsync();
        }
    }
}
