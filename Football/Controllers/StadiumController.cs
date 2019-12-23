using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.interfaces;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Football.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StadiumController : ControllerBase
    {
        private readonly IStadiumService stadiumService;
        public StadiumController(IStadiumService stadiumService)
        {
            this.stadiumService = stadiumService;
        }
        [HttpGet]
        public Task<ICollection<Stadium>> GetStadium()
        {
            return stadiumService.GetStadium();
        }
        [HttpPost]
        public Task<Stadium> AddStadium(Stadium stadium)
        {
            return stadiumService.AddStadium(stadium);
        }
    }
}