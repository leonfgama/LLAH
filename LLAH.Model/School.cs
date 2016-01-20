using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLAH.Model
{
    public class School
    {
        public string Name { get; set; }
        public string Cnpj { get; set; }
        public virtual Location Location { get; set; }
    }
}
