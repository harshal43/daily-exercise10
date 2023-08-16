using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CourseAppEx.Models;

namespace CourseAppEx.Data
{
    public class CourseDbContext : DbContext
    {
        public CourseDbContext (DbContextOptions<CourseDbContext> options)
            : base(options)
        {
        }

        public DbSet<CourseAppEx.Models.Courses> Courses { get; set; } = default!;
    }
}
