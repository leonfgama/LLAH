using LLAH.Model.Base;
using LLAH.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLAH.Model
{
    public class User : BaseModel
    {
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public int LoginTryNumber { get; set; }
        public UserType UserType { get; set; }
        
    }
}
