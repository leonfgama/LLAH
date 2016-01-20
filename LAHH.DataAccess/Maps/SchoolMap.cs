using LLAH.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAHH.DataAccess.Maps
{
    public class SchoolMap : EntityTypeConfiguration<School>
    {
        public SchoolMap()
        {
            this.HasMany<Student>(s => s.Students)
               .WithMany(c => c.Schools)
               .Map(cs =>
               {
                   cs.MapLeftKey("SchoolId");
                   cs.MapRightKey("StudentId");
                   cs.ToTable("StudentSchool");
               });

            this.Property(x => x.Cnpj).IsRequired();
            this.Property(x => x.Name).IsRequired();
            this.Property(x => x.PhoneNumber).IsRequired();
        }
    }
}
