using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LLAH.Model.Enum;

namespace LLAH.Model.Base
{
    public class People : BaseModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public GenreType Genre { get; set; }
    }
}
