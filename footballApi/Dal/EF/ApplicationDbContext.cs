using Dal.Footballer.Models;
using Dal.Team.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Dal.EF
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<FootballerDal>  Footballers { get; set; }
        public DbSet<TeamDal> Teams { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
