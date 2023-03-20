using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB1
{
    class Requests:IRequests
    {
        private IDBContext DateContext;
        public Requests(IDBContext dbContext)
        {
            DateContext = dbContext;
        }

        public double GetAverageValueOfJournals()
        {
            return DateContext.journals.Average(x => x.Circulation);
        }

        public IEnumerable<Author> GetAuthors()
        {
            return from item in DateContext.authors
                   select item;
        }

        public IEnumerable<ArticleJournal> SortSubmissionDate()
        {
            return from item in DateContext.articlesJournals
                   orderby item.SubmissionDate
                   select item;
        }

        public IEnumerable<Journal> MonthlyArticle()
        {
            return from item in DateContext.journals
                   where item.Frequency== "monthly"
                   select item;
        }

        public IEnumerable<Author> GetWeeklyAuthors()
        {
            return from author in DateContext.authors
                   join journal in DateContext.journals on author.ID equals journal.ID
                   where journal.Frequency == "weekly"
                   select author;        
        }




    }
}
