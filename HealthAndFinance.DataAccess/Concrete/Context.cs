using HealthAndFinance.Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthAndFinance.DataAccess.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-VLIOH37;database=HealthAndFinance;integrated security=true;Trust Server Certificate=true;");
            base.OnConfiguring(optionsBuilder);
        }
        

        public DbSet<HealthAnalyzer> HealthAnalyzers { get; set; }
        public DbSet<HealthEntry> HealthEntries { get; set; }
        public DbSet<HealthGoal> HealthGoals { get; set; }
    }
}
