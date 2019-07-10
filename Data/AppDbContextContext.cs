using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RestfulAPInetCore.Models
{
    public class AppDbContextContext : DbContext
    {
        public AppDbContextContext (DbContextOptions<AppDbContextContext> options)
            : base(options)
        {
        }

        public DbSet<RestfulAPInetCore.Models.Game> Game { get; set; }
    }
}
