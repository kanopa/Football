using BLL.interfaces;
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.services
{
    public class StadiumService : IStadiumService
    {
        private readonly IStadiumRepository stadiumRepository;

        public StadiumService(IStadiumRepository stadiumRepository)
        {
            this.stadiumRepository = stadiumRepository;
        }
        public async Task<ICollection<Stadium>> GetStadium()
        {
            return await stadiumRepository.GetStadium();
        }
    }
}
