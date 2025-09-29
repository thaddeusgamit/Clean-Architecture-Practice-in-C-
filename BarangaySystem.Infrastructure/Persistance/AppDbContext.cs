using Microsoft.EntityFrameworkCore;
using BarangaySystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarangaySystem.Infrastructure.Persistance
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

        public DbSet<Reports> Reports{ get; set; }
        public DbSet<Positions> Positions{ get; set; }

    }
}
