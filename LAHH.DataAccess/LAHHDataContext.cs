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
        #region [ Commands to use Migrations ]
        // How to Use Migration, use this commands in Tools --> Library Package Manager --> Package Manager Console
        // Install
        //Enable-Migrations -ProjectName ReasonConsulting.TopManager.DataAccess -StartUpProjectName ReasonConsulting.TopManager.Web.Admin -Verbose

        // Update
        //Update-Database -Force -Verbose -ProjectName LAHH.DataAccess
        #endregion

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
