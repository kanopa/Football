using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int CountPlayers { get; set; }
    }
}
