using BLL.interfaces;
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.services
{
    public class MatchService : IMatchService
    {
        private readonly IMatchRepository matchRepository;
        public MatchService(IMatchRepository matchRepository)
        {
            this.matchRepository = matchRepository;
        }
        public async Task<Match> AddMatch(Match match)
        {
            return await matchRepository.AddMatch(match);
        }

        public async Task<ICollection<Match>> GetTeams()
        {
            return await matchRepository.GetMatch();
        }
    }
}
