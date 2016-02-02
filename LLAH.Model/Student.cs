using LLAH.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLAH.Model
{
    public class Student : People
    {
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual IList<School> Schools { get; set; }
        public virtual IList<Parent> Parents { get; set; }
    }
}
