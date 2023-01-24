using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TopTrumps.Models;

namespace TopTrumps.Data
{
    public class TopTrumpsContext : DbContext
    {
        public TopTrumpsContext (DbContextOptions<TopTrumpsContext> options)
            : base(options)
        {
        }

        public DbSet<TopTrumps.Models.Cats> Cats { get; set; } = default!;
    }
}
