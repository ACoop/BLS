using System;
using System.Collections.Generic;

namespace Data
{
    public class Day
    {
        public int ID { get; set; }
        public string DayName { get; set; }
        public DateTime DayDate { get; set; }
        public string BodyArea { get; set; }
        public virtual ICollection<Exercise> Exercises { get; set; }
    }
}