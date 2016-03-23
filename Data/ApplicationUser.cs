using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data
{
    public class ApplicationUser:IdentityUser
    {
        public string Fullname { get; set; }
    }
}
