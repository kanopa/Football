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
    public class TournamentController : ControllerBase
    {
        private readonly ITournamentService tournamentService;
        public TournamentController(ITournamentService tournamentService)
        {
            this.tournamentService = tournamentService;
        }
        [HttpGet]
        public Task<ICollection<Tournament>> GetTournaments()
        {
            return tournamentService.GetTournament();
        }
    }
}