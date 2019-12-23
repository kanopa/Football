using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IMatchRepository
    {
        Task<ICollection<Match>> GetMatch();
        Task<Match> AddMatch(Match match);
    }
}
