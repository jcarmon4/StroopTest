using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StroopTest.Models;

namespace StroopTest.Models
{
    public class StroopTestContext : DbContext
    {
        public StroopTestContext (DbContextOptions<StroopTestContext> options)
            : base(options)
        {
        }

        public DbSet<StroopTest.Models.User> User { get; set; }

        public DbSet<StroopTest.Models.ActivityRecord> ActivityRecord { get; set; }
    }
}
