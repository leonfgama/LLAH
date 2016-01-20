using LLAH.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLAH.Model
{
    public class Teacher : People
    {
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
