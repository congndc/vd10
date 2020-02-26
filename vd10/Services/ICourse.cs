using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vd10.Models;

namespace vd10.Services
{
   public interface ICourse
    {
        Task Add(Course course);
        bool Exit(int ID);
        Task Update(Course course);
        Task Remove(int ID);
        Task<Course> FindById(int ID);
        Task<List<Course>> GetAll();
    }
}
