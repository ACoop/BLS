using System;
using System.Collections.Generic;

namespace Data
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<WeekPlan> WeekPlans { get; set; }
    }
}
