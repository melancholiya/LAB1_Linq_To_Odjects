using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB1
{
    public class Author
    {
        public int _id { get; set; }
        public string _firstName { get; set; }
        public string _secondName { get; set; }
        public string _surname { get; set; }
        public string _organization { get; set; }

        public override string ToString()
        {
            return $"Name:{_firstName} {_secondName} {_surname}"+
                   $"Organazation:{_organization}";
        }
    }
}
