using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vd10.Models;
using vd10.Services;

namespace vd10.Repository
{
    public class GenderRepository : IGender
    {
        private NewContext newContext;
        public GenderRepository(NewContext _newContext)
        {
            newContext = _newContext;
        }

        public async  Task Add(Gender gender)
        {
            newContext.Gender.Add(gender);
            await newContext.SaveChangesAsync();
        }

        public bool Exit(int ID)
        {
            Gender gender =  newContext.Gender.Find(ID);
            if (gender != null)
                return true;
            else return false;
        }

        public async  Task<Gender> FindById(int ID)
        {
            Gender gender = await newContext.Gender.FindAsync(ID);
            return gender;
        }

        public async  Task<List<Gender>> GetAll()
        {
            return await newContext.Gender.ToListAsync();

        }

        public async Task Remove(int ID)
        {
            Gender gender = await newContext.Gender.FindAsync(ID);
            newContext.Gender.Remove(gender);
            await newContext.SaveChangesAsync();
        }

        public async Task Update(Gender gender)
        {
            Gender newGender = await newContext.Gender.FindAsync(gender.GenderID);
            newGender = gender;
            await newContext.SaveChangesAsync();
        }
    }
}
