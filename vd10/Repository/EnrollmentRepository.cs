using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vd10.Models;
using vd10.Services;

namespace vd10.Repository
{
    public class EnrollmentRepository : IEnrollment
    {
        private NewContext newContext;
        public EnrollmentRepository(NewContext _newContext)
        {
            newContext = _newContext;
        }

        public async Task Add(Enrollment enrollment)
        {
            newContext.Enrollment.Add(enrollment);
            await newContext.SaveChangesAsync();
        }

        public bool Exit(int ID)
        {
            Enrollment enrollment = newContext.Enrollment.Find(ID);
            if (enrollment != null)
                return true;
            else return false;
        }

        public async Task<Enrollment> FindById(int ID)
        {
            Enrollment enrollment = await newContext.Enrollment.FindAsync(ID);
            return enrollment;
        }

        public async Task<List<Enrollment>> GetAll()
        {
            return await newContext.Enrollment.ToListAsync();
        }

        public async Task Remove(int ID)
        {
            Enrollment enrollment = await newContext.Enrollment.FindAsync(ID);
            newContext.Enrollment.Remove(enrollment);
            await newContext.SaveChangesAsync();


        }

        public async Task Update(Enrollment enrollment)
        {
            Enrollment newEnrollment = await newContext
                .Enrollment.FindAsync(enrollment.EnrollmentID);
            newEnrollment = enrollment;
            await newContext.SaveChangesAsync();

        }
    }
}
