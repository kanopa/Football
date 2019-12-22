using BLL.interfaces;
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.services
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository playerRepository;
        public PlayerService(IPlayerRepository playerRepository)
        {
            this.playerRepository = playerRepository;
        }
        public async Task<ICollection<Player>> GetPlayers()
        {
            return await playerRepository.GetPlayers();
        }
    }
}
