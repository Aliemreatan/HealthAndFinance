﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthAndFinance.Entities.Concrete
{
    public class HealthEntry
    {
        public int Id { get; set; }
        public required DateTime Date { get; set; }
        public int? Steps { get; set; }
        public double? CaloriesBurned { get; set; }
        public double? SleepHours { get; set; }
        public string? Notes { get; set; }

        public required int UserId { get; set; }
        public User? User { get; set; }
    }
}