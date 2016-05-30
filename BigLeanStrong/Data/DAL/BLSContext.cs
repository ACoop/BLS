using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL
{
    public class BLSContext : DbContext
    {

        public BLSContext() : base("BLSContext")
        {
        }

        public DbSet<Day> Days { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<WeekPlan> Weekplans { get; set; }
        public DbSet<Exercise> Exercises { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
