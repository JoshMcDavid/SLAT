using Microsoft.EntityFrameworkCore;
using SLAT.Core.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLAT.Core.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        //public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<AdminsDataModel> Admins { get; set; }
        public DbSet<AttendeesDataModel> Attendees { get; set;}
        public DbSet<CoursesDataModel> Courses { get; set; }
        public DbSet<LecturersDataModel> Lecturers { get; set;}
        public DbSet<LecturesDataModel> Lectures { get; set; }
        public DbSet<LecturerCoursesDataModel> LecturerCourses { get; set; }
        public DbSet<StudentCoursesDataModel> StudentCourses { get; set; }
        public DbSet<StudentsDataModel> Students { get; set; }
    }
}
