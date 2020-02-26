using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vd10.Models;

namespace vd10.Repository
{
    public class NewContext:DbContext
    {
        public NewContext(DbContextOptions<NewContext> options) : base(options)
        {

        }
       public DbSet<Student> Student { get; set; }
       public DbSet<Course> Course { get; set; }
       public DbSet<Gender> Gender { get; set; }
       public DbSet<Enrollment> Enrollment { get; set; }
    }
}
