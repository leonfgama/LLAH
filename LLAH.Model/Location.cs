using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLAH.Model
{
    public class Location
    {
        public string Street { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public int ZipCode { get; set; }
        public int ApartamentNumber { get; set; }
        public string Description { get; set; }
    }
}
