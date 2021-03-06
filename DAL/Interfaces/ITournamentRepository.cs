﻿using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ITournamentRepository
    {
        Task<ICollection<Tournament>> GetTournament();
    }
}
