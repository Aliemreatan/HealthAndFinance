using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthAndFinance.Entities.Concrete
{
    public class HealthGoal
    {
        public int Id { get; set; }
        public required string GoalName { get; set; }
        public string? GoalDescription { get; set; }
        public required DateTime? StrartDate { get; set; }
        public required DateTime TargerDate { get; set; }
        public bool IsAchieved { get; set; } = false;

        public required int UserId { get; set; }
        public AppUser? User { get; set; }
    }
}
