using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB1
{
    public class ArticleJournal
    {
        public int ArticleJournalId { get; set; }
        public DateTime SubmissionDate { get; set; }

        public int ArticleId { get; set; }

        public override string ToString()
        {
            return $"Date of publication:{SubmissionDate}";
        }

    }
}
