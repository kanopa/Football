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
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerService playerService;
        public PlayerController(IPlayerService playerService)
        {
            this.playerService = playerService;
        }
        [HttpGet]
        public Task<ICollection<Player>> GetPlayers()
        {
            return playerService.GetPlayers();
        }
        [HttpPost]
        public Task<Player> AddPlayer(Player player)
        {
            return playerService.AddPlayer(player);
        }
    }
}