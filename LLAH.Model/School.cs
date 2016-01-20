using LLAH.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLAH.Model
{
    public class School : BaseModel
    {
        public string Name { get; set; }
        public string Cnpj { get; set; }
        public string Site { get; set; }
        public int PhoneNumber { get; set; }        
        public int Locationid { get; set; }
        public int UserId { get; set; }
        public virtual Location Location { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
