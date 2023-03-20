using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LAB1
{
    public class Journal
    {
        //name convention c# code convention 
        // private int _id; 
        public int ID { get; set; }
        public string Name { get; set; }

        public string Frequency { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int Circulation { get; set; }



        public override string ToString()
        {
            return $"Name:{Name} \t"+
                   $"Frequency:{Frequency}\t"+
                   $"ReleaseDate:{ReleaseDate}\t"+
                   $"Circulation:{Circulation}";
        }

    }
}
