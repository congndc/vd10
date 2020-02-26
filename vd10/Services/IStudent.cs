using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vd10.Models;

namespace vd10.Services
{
    public interface IStudent
    {
        Task Add(Student student);
        bool Exit(int ID);
        Task Update(Student student);
        Task Remove(int ID);
        Task<Student> FindById(int ID);
        Task<List<Student>> GetAll();
    }
}
