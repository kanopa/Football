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

        public async Task<Team> AddTeam(Team team)
        {
            var newTeam = await db.Teams.AddAsync(team);
            await db.SaveChangesAsync();
            return newTeam.Entity;
        }

        public async Task<ICollection<Team>> GetTeams()
        {
            return await db.Teams.ToListAsync();
        }

        public async Task UpdateTeam(int id)
        {
            var find = await db.Teams.FirstOrDefaultAsync(x => x.Id == id);
            if (find != null)
                find.CountPlayers++;
            db.Update(find);
            await db.SaveChangesAsync();
        }
    }
}
