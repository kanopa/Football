using DAL.Context;
using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class StadiumRepository: IStadiumRepository
    {
        private FootballContext db;
        public StadiumRepository(FootballContext db)
        {
            this.db = db;
        }

        public async Task<Stadium> AddStadium(Stadium stadium)
        {
            var newStadium = await db.Stadiums.AddAsync(stadium);
            await db.SaveChangesAsync();
            return newStadium.Entity;
        }

        public async Task<ICollection<Stadium>> GetStadium()
        {
            return await db.Stadiums.ToListAsync();
        }
    }
}
