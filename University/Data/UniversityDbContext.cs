using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Models;

namespace University.Data
{
    public class UniversityDbContext:DbContext
    {
        public UniversityDbContext(DbContextOptions<UniversityDbContext> options):base(options)
        {

        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Student_Course> Student_Courses { get; set; }
    }
}
