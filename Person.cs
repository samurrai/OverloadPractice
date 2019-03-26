using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadPractice
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public static bool operator ==(Person first, Person second)
        {
            return first.Name == second.Name && first.Surname == second.Surname;
        }
        public static bool operator !=(Person first, Person second)
        {
            return first.Name != second.Name && first.Surname != second.Surname;
        }
    }
}
