using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL
{
    class BLSInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<BLSContext>
    {
        protected override void Seed(BLSContext context)
        {
            var users = new List<User>
            {
            new User{Name="AndrewTest"},
            new User{Name="AndrewTest2"}
            };

            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();
        }
    }
}
