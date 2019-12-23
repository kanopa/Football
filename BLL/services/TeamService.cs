using BLL.interfaces;
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.services
{
    public class TeamService : ITeamService
    {
        private readonly ITeamRepository teamRepository;
        public TeamService(ITeamRepository teamRepository)
        {
            this.teamRepository = teamRepository;
        }

        public async Task<Team> AddTeam(Team team)
        {
            return await teamRepository.AddTeam(team);
        }

        public async Task<ICollection<Team>> GetTeams()
        {
            return await teamRepository.GetTeams();
        }

        public async Task UpdateTeam(int id)
        {
            await teamRepository.UpdateTeam(id);
        }
    }
}
