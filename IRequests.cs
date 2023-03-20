using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB1
{
    interface IRequests
    {
        double GetAverageValueOfJournals();
        IEnumerable<Author> GetAuthors();
        IEnumerable<Article> SortSubmissionDate();
        IEnumerable<Journal> MonthlyArticle();
        IEnumerable<Author> GetWeeklyAuthors();

    }
}
