using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab17Cameron.Models;

namespace Lab17Cameron.Models
{
    public class Lab17CameronContext : DbContext
    {
        public Lab17CameronContext (DbContextOptions<Lab17CameronContext> options)
            : base(options)
        {
        }

        public DbSet<Lab17Cameron.Models.Destination> Destination { get; set; }

        public DbSet<Lab17Cameron.Models.Season> Season { get; set; }

        public DbSet<Lab17Cameron.Models.Supplies> Supplies { get; set; }
    }
}
