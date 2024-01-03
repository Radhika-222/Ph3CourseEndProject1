using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CourseEndProject1_EMS.Models;

namespace CourseEndProject1_EMS.Data
{
    public class DeptMasterDbContext : DbContext
    {
        public DeptMasterDbContext (DbContextOptions<DeptMasterDbContext> options)
            : base(options)
        {
        }

        public DbSet<CourseEndProject1_EMS.Models.DeptMaster> DeptMaster { get; set; } = default!;
    }
}
