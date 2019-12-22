using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Player
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public string FullName { get; set; }
        public DateTime BornDate { get; set; }
        public DateTime ContractDate { get; set; }
    }
}
