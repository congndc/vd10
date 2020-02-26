using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vd10.Models;

namespace vd10.Services
{
   public interface IGender
    {
        Task Add(Gender gender);
        bool Exit(int ID);
        Task Update(Gender gender);
        Task Remove(int ID);
        Task<Gender> FindById(int ID);
        Task<List<Gender>> GetAll();

    }
}
