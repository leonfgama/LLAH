using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLAH.Model
{
    public class Student
    {
        public virtual List<School> Schools { get; set; }

        public virtual List<Parent> Parents { get; set; }    
    }
}
