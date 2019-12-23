using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.interfaces
{
    public interface ITeamService
    {
        Task<ICollection<Team>> GetTeams();
        Task<Team> AddTeam(Team team);
    }
}
