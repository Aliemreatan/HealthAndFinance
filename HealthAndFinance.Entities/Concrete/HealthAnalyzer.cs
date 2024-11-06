using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthAndFinance.Entities.Concrete
{
    public class HealthAnalyzer
    {
        [Key]
        public int Id { get; set; }
        public static double CalculateAverageSteps(AppUser user, DateTime startDate, DateTime endDate)
        {
            var steps = user.HealthEntries
                                .Where(entry => entry.Date >= startDate && entry.Date <= endDate && entry.Steps.HasValue)
                                .Select(entry => entry.Steps.Value);

            return steps.Any() ? steps.Average() : 0;
        }
    }
}
