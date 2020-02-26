using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vd10.Models;

namespace vd10.Services
{
   public interface IEnrollment
    {
        Task Add(Enrollment enrollment);
        bool Exit(int ID);
        Task Update(Enrollment enrollment);
        Task Remove(int ID);
        Task<Enrollment> FindById(int ID);
        Task<List<Enrollment>> GetAll();
    }
}
