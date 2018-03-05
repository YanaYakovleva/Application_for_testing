using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom
{
    class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public User(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }


    }
}
