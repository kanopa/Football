using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.interfaces;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Football.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly ITeamService teamService;
        public TeamController(ITeamService teamService)
        {
            this.teamService = teamService;
        }
        [HttpGet]
        public Task<ICollection<Team>> GetTeams()
        {
            return teamService.GetTeams();
        }
        [HttpPost]
        public Task<Team> AddTeam(Team team)
        {
            return teamService.AddTeam(team);
        }
    }
}