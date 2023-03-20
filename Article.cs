using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB1
{
    // Arcticle
    //information about article
    //ArticleInJournal 

    //2 ways : identity(autoincrement of int for each row) | Guid.NewGuid() 
    public class Article
    {
        //Arcticle
        public int ID { get; set; }
        public string Title { get; set; }

        public int AuthorID { get; set; }
        public Journal Journal { get; set; }
        //end Arcticle

        //public override string ToString()
        //{
        //    return $"Title:{Title}\t надійшла в редакцію:\t {_submissionDate}";
        //}



    }

}
