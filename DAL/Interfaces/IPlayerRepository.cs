using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IPlayerRepository
    {
        Task<ICollection<Player>> GetPlayers();
    }
}
