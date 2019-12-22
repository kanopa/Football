using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Match
    {
        public int Id { get; set; }
        public int TournamentId { get; set; }
        public Tournament Tournament { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public int StadiumId { get; set; }
        public Stadium Stadium { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

    }
}
