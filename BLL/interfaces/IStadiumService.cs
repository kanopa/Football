using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.interfaces
{
    public interface IStadiumService
    {
        Task<ICollection<Stadium>> GetStadium();
    }
}
