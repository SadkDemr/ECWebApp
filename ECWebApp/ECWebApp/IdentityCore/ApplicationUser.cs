using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECWebApp.IdentityCore
{
    public class ApplicationUser:IdentityUser
    {
        public string Name { get; set; }
        public string SurName { get; set; }
    }
}
