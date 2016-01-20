using LAHH.DataAccess.Maps;
using LLAH.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAHH.DataAccess
{
    public class LAHHDataContext : DbContext
    {
        public LAHHDataContext()
            : base("LLAHDbContext")
        {            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {            
            base.OnModelCreating(modelBuilder);


            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            //modelBuilder.Configurations.Add(new SchoolMap());
            //modelBuilder.Configurations.Add(new ParentMap());
            modelBuilder.Configurations.Add(new StudentMap());
        }

        public DbSet<Parent> Parent { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<School> School { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Student> Student { get; set; }
        //public DbSet<StudentSchool> StudentSchool { get; set; }
        //public DbSet<StudentParent> StudentParent { get; set; }
        public DbSet<Admin> Admin { get; set; }
    }
}
