using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Access
{
    public class AccessDB: DbContext
    {
        public AccessDB() : base("dbConnection2015") { }

        public DbSet<User> List_of_users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
