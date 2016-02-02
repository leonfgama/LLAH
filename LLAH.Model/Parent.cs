using LLAH.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLAH.Model
{
    public class Parent : People
    {
        public string Cpf { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual IList<Student> Students { get; set; }
        
    }
}
