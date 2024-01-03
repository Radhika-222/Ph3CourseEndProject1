using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CourseEndProject1_EMS.Models;

namespace CourseEndProject1_EMS.Data
{
    public class EmpProfileDbContext : DbContext
    {
        public EmpProfileDbContext (DbContextOptions<EmpProfileDbContext> options)
            : base(options)
        {
        }

        public DbSet<CourseEndProject1_EMS.Models.EmpProfile> EmpProfile { get; set; } = default!;
    }
}
