using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LAB1
{
    internal interface IDBContext
    {
        IEnumerable<Article> articles { get; }
        IEnumerable<Author> authors { get; }
        IEnumerable<Journal> journals { get; }
        IEnumerable<Organization> organizations { get; }
        IEnumerable<ArticleJournal> articlesJournals { get; }
        IEnumerable<ArticleAuthor> articleAuthors { get; }
    }
}
