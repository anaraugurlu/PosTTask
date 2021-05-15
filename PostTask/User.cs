using BaseNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserNamespace
{
    public class User : Base
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return $@"Id{Id}
               Name    {Name}
               Surname {Surname}
               Age     {Age}
               Email    {Email}
               Password{Password}";
        }
       
    }
}
