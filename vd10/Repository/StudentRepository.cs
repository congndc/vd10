using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using vd10.Models;
using vd10.Services;



namespace vd10.Repository
{
    public class StudentRepository : IStudent
    {
        private NewContext newContext;
        public StudentRepository(NewContext _newContext)
        {
            newContext = _newContext;
        }

        public async Task Add(Student student)
        {
            newContext.Student.Add(student);
            await newContext.SaveChangesAsync();
        }

        public bool Exit(int ID)
        {
            Student student = newContext.Student.Find(ID);
            if (student != null)
                return true;
            else return false;
        }

        public async Task<Student> FindById(int ID)
        {
            Student student = await newContext.Student.FindAsync(ID);
            return student;
        }

        public async Task<List<Student>> GetAll()
        {
            return await newContext.Student.ToListAsync();
        }

        public async Task Remove(int ID)
        {
            Student student = await newContext.Student.FindAsync(ID);
            newContext.Student.Remove(student);
            await newContext.SaveChangesAsync();
        }

        public async Task Update(Student student)
        {
            Student newstudent = await newContext.Student.FindAsync(student.StudentID);
            newstudent = student;
            await newContext.SaveChangesAsync();
        }
    }
}
