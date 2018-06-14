using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using lab_5.Models;

namespace lab_5.context
{
    public class MyContext : DbContext
    {
        public MyContext() : base("MyContext")
        {

        }

        public DbSet<Models.city> cities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}