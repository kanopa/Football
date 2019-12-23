using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ITeamRepository
    {
        Task<ICollection<Team>> GetTeams();
        Task<Team> AddTeam(Team team);
        Task UpdateTeam(int id);
    }
}
