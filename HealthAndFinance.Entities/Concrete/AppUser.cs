using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthAndFinance.Entities.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        
        public string NameSurname { get; set; }

		
		public List<HealthEntry> HealthEntries { get; set; } = new();
        public List<HealthGoal> HealthGoals { get; set; } = new();
    }
}
