using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB1
{
    public class Article
    {
        public int _id { get; set; }
        public string _title { get; set; }
        private DateTime _submissionDate { get; set; }


        public int _idAuthor { get; set; }
        public int _idJornal { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }



    }

}
