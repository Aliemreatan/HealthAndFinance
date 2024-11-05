using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthAndFinance.Entities.Concrete
{
    public class User : IdentityUser<int>
    {
        [Key]
        public int Id {  get; set; }
        public string Name { get; set; }
        public  string NameSurname { get; set; }

        public int? Weight { get; set; }

        public int? Height { get; set; }

        public int? BKI { get; set; }

        public bool IsActive { get; set; }
        
        public List<HealthEntry> HealthEntries { get; set; } = new();
        public List<HealthGoal> HealthGoals { get; set; } = new();
    }
}
