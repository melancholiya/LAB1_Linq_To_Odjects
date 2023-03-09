using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB1
{
    public class Journal
    {
        public int _id { get; set; }
        public string _name { get; set; }

        public string _frequency { get; set; }

        public DateTime _releaseDate { get; set; }

        public uint _circulation { get; set; }

        public override string ToString()
        {
            return $"Name:{_name}"+
                   $"Frequency:{_frequency}"+
                   $"ReleaseDate:{_releaseDate}"+
                   $"Circulation:{_circulation}";
        }

    }
}
