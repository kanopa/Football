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
    public class MatchController : ControllerBase
    {
        private readonly IMatchService matchService;
        public MatchController(IMatchService matchService)
        {
            this.matchService = matchService;
        }
        [HttpGet]
        public Task<ICollection<Match>> GetMatches()
        {
            return matchService.GetTeams();
        }
        [HttpPost]
        public Task<Match> AddMatch(Match match)
        {
            return matchService.AddMatch(match);
        }
    }
}