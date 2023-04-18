using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectW.Models;

namespace ProjectW.Data
{
    public class ProjectWContext : DbContext
    {
        public ProjectWContext (DbContextOptions<ProjectWContext> options)
            : base(options)
        {
        }

        public DbSet<ProjectW.Models.Book> Book { get; set; } = default!;

        public DbSet<ProjectW.Models.Category> Category { get; set; } = default!;
    }
}
