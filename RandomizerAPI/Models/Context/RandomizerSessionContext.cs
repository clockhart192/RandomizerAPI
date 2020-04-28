using Microsoft.EntityFrameworkCore;
using RandomizerAPI.Models.BaseModels;
using RandomizerAPI.Models.InfrastructureModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomizerAPI.Models.Context
{
    public class RandomizerSessionContext : DbContext
    {
        public RandomizerSessionContext()
        {
        }

        public RandomizerSessionContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<RandomizerSession> RandomizerSessions { get; set; }
        public DbSet<Error> Errors { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Zone> Zones { get; set; }
    }
}
