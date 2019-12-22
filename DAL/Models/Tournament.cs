using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Tournament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}
