using System.Collections.Generic;

namespace Data
{
    public class Exercise
    {
        public int ID { get; set; }
        public string ExerciseName { get; set; }
        IList<int> Sets { get; set; }
        public string BarType { get; set; }
        public int Weight { get; set; }
        public string Dificulty { get; set; }
    }
}