using LLAH.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAHH.DataAccess.Maps
{
    public class StudentMap :  EntityTypeConfiguration<Student>
    {
        public StudentMap()
        {

            //this.HasRequired(x => x.Parents)
            //    .WithMany()
            //    .WillCascadeOnDelete(false);

            //this.HasRequired(x => x.Schools)
            //    .WithMany()
            //    .WillCascadeOnDelete(false);

            this.HasMany<Parent>(s => s.Parents)
                .WithMany(c => c.Students)                
                .Map(cs =>
                        {
                            cs.MapLeftKey("StudentId");
                            cs.MapRightKey("ParentId");
                            cs.ToTable("StudentParent");
                        });

            this.HasMany<School>(s => s.Schools)
                .WithMany(c => c.Students)
                .Map(cs =>
                {
                    cs.MapLeftKey("StudentId");
                    cs.MapRightKey("SchoolId");
                    cs.ToTable("StudentSchool");
                });
        }
    }
}
