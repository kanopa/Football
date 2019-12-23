using BLL.interfaces;
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.services
{
    public class TournamentService : ITournamentService
    {
        private readonly ITournamentRepository tournamentRepository;
        public TournamentService(ITournamentRepository tournamentRepository)
        {
            this.tournamentRepository = tournamentRepository;
        }
        public async Task<ICollection<Tournament>> GetTournament()
        {
            return await tournamentRepository.GetTournament();
        }
    }
}
