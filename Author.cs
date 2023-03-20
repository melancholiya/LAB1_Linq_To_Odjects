using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB1
{
    public class Author
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int OrganizationID { get; set; }


        public override string ToString()
        {
            return $"Name:{_firstName} {_secondName}\t працює в:\t {_organization}";
        }
    }
}
