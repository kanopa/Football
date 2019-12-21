using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Context
{
    class FootballContext : DbContext
    {
        public FootballContext(DbContextOptions<FootballContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
