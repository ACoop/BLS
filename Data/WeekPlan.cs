using System.Collections.Generic;

namespace Data
{

    public class WeekPlan
    {
        public int ID { get; set; }
        public string WeekName { get; set; }

        public virtual ICollection<Day> Days { get; set; }
    }
}