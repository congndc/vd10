using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vd10.Models;
using vd10.Services;

namespace vd10.Repository
{
    public class CourseRepository : ICourse
    {
        private NewContext newContext;
        public CourseRepository(NewContext _newContext)
        {
            newContext = _newContext;
        }

        public async Task Add(Course course)
        {
            newContext.Add(course);
            await newContext.SaveChangesAsync();

        }

        public bool Exit(int ID)
        {
            Course course = newContext.Course.Find(ID);
            if (course != null)
                return true;
            else return false;
        }

        public async Task<Course> FindById(int ID)
        {
            Course course = await newContext.Course.FindAsync(ID);
            return course;
        }

        public async Task<List<Course>> GetAll()
        {
            return await newContext.Course.ToListAsync();
        }

        public async Task Remove(int ID)
        {
            Course course = await newContext.Course.FindAsync(ID);
            newContext.Course.Remove(course);
            await newContext.SaveChangesAsync();
        }

        public async Task Update(Course course)
        {
            Course newcourse = await newContext.Course.FindAsync(course.CourseID);
            newcourse = course;
            await newContext.SaveChangesAsync();
        }
        /*------------------------*/
        
      

        

        

     

       
      

        //public IEnumerable<Course> GetCourse => newContext.Course;

        //public void Add(Course _course)
        //{
        //    newContext.Course.Add(_course);
        //    newContext.SaveChanges();
        //}

        //public Course GetCourse(int ID)
        //{
        //    return newContext.Course.Find(ID);
        //}

        //public void Remove(int ID)
        //{
        //    Course dbCourse = newContext.Course.Find(ID);
        //    newContext.Remove(dbCourse);
        //}

    }
}
