using LLAH.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAHH.DataAccess.Maps
{
    public class ParentMap : EntityTypeConfiguration<Parent>
    {
        public ParentMap()
        {
            this.HasMany<Student>(x => x.Students).WithMany(c => c.Parents)
                .Map(cs =>
                {
                    cs.MapLeftKey("ParentId");
                    cs.MapRightKey("StudentId");
                    cs.ToTable("StudentParent");
                });

            this.Property(x => x.Name).IsRequired();
            this.Property(x => x.LastName).IsRequired();
        }
    }
}
