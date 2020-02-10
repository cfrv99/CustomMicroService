using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Domain.Entites.Base;

namespace UserService.Domain.Entites
{
    public class AppUser:Entity<int>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Surname { get; set; }
    }
}
