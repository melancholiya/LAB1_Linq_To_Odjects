using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB1
{
    //DBContext 

    //class with list and method insiode or outer initializer that should be called from program cs 
    public class DataList : IDBContext
    {
        //private Author Author1 = new Author()
        //{
        //    ID = 1,
        //    FirstName = "Emily",
        //    SecondName = "Johnspn",
        //    OrganizationID = 1,
        //};
        //private Author Author2 = new Author()
        //{
        //    ID = 2,
        //    FirstName = "Jacob",
        //    SecondName = "Smith",
        //    OrganizationID = 2,
        //};
        //private Author Author3 = new Author()
        //{
        //    ID = 3,
        //    FirstName = "Samantha",
        //    SecondName = "Lee",
        //    OrganizationID = 3,
        //};
        //private Author Author4 = new Author()
        //{
        //    ID = 4,
        //    FirstName = "James",
        //    SecondName = "Taylor",
        //    OrganizationID = 4,
        //};
        //private Author Author5 = new Author()
        //{
        //    ID = 5,
        //    FirstName = "Emma",
        //    SecondName = "Thompson",
        //    OrganizationID = 5,
        //};

        private Journal Journal1 = new Journal()
        {
            ID = 1,
            Name = "Nature",
            Frequency = "weekly",
            ReleaseDate = new DateTime(2022, 11, 12),
            Circulation = 2000,
        };
        private Journal Journal2 = new Journal()
        {
            ID = 2,
            Name = "Science & Innovation",
            Frequency = "weekly",
            ReleaseDate = new DateTime(2023, 3, 1),
            Circulation = 1000,
        };
        private Journal Journal3 = new Journal()
        {
            ID = 3,
            Name = "Advances in Engineering",
            Frequency = "monthly",
            ReleaseDate = new DateTime(2022, 10, 1),
            Circulation = 1500,
        };
        private Journal Journal4 = new Journal()
        {
            ID = 4,
            Name = "Psychological Science",
            Frequency = "monthly",
            ReleaseDate = new DateTime(2023, 1, 23),
            Circulation = 1300,
        };
        private Journal Journal5 = new Journal()
        {
            ID = 5,
            Name = "Cell",
            Frequency = "every 2 months",
            ReleaseDate = new DateTime(2023, 2, 2),
            Circulation = 2200,
        };
        public IEnumerable<Journal> journals => new List<Journal>()
        {
            Journal1,Journal2,Journal3,Journal4,Journal5
        };

        //public IEnumerable<Journal> journals => new List<Journal>()
        //{
        //  new Journal(){Id=1,_name="Nature",_frequency="weekly",_releaseDate=new DateTime(2022,11,12),_circulation=2000},
        //  new Journal(){Id=2,_name="Science & Innovation",_frequency="weekly",_releaseDate=new DateTime(2023,3,1),_circulation=1000},
        //  new Journal(){Id=3,_name="Advances in Engineering",_frequency="monthly",_releaseDate=new DateTime(2022,10,1),_circulation=1500},
        //  new Journal(){Id=4,_name="Psychological Science",_frequency="monthly",_releaseDate=new DateTime(2023,1,23),_circulation=1300},
        //  new Journal(){Id=5,_name="Cell",_frequency="every 2 months",_releaseDate=new DateTime(2023,2,2),_circulation=2200}
        //};
        public IEnumerable<Author> authors => new List<Author>()
        {
            new Author(){ID=1,FirstName="Emily",SecondName="Johnson",OrganizationID=1},
            new Author(){ID=2,FirstName="Jacob",SecondName="Smith",OrganizationID=2},
            new Author(){ID=3,FirstName="Samantha ",SecondName="Lee",OrganizationID=3},
            new Author(){ID=4,FirstName="James",SecondName="Taylor",OrganizationID=1},
            new Author(){ID=5,FirstName="Emma",SecondName="Thompson",OrganizationID=2}
        };

        public IEnumerable<Article> articles => new List<Article>()
        {
            new Article(){ID=1,Title="How to Improve Your Health through Proper Nutrition",AuthorID=1,Journal=Journal1},
            new Article(){ID=2,Title="5 Easy Ways to Reduce Stress in Your Everyday Life",AuthorID=2,Journal=Journal2},
            new Article(){ID=3,Title="The Benefits of Regular Exercise for Mental Health",AuthorID=3,Journal=Journal3},
            new Article(){ID=4,Title="Tips for Effective Time Management in the Workplace",AuthorID=4,Journal=Journal4}

        };
        public IEnumerable<Organization> organizations => new List<Organization>()
        {
            new Organization(){ID=1,Name="Penguin Random House"},
            new Organization(){ID=2,Name="HarperCollins"},
            new Organization(){ID=3,Name="Hachette Book Group"},
            new Organization(){ID=4,Name="Macmillan Publishers"}
        };
        public IEnumerable<ArticleJournal> articlesJournals => new List<ArticleJournal>()
        {
            new ArticleJournal() {ArticleJournalId=1, ArticleId=1, SubmissionDate=new DateTime(2022,9,22)},
            new ArticleJournal(){ArticleJournalId=2,ArticleId=2, SubmissionDate=new DateTime(2022,10,1)},
            new ArticleJournal(){ArticleJournalId=3,ArticleId=3,SubmissionDate=new DateTime(2023,2,18)},
            new ArticleJournal(){ArticleJournalId=4,ArticleId=4, SubmissionDate=new DateTime(2023,3,10)}
        };
        public IEnumerable<ArticleAuthor> articleAuthors => new List<ArticleAuthor>()
        {
            new ArticleAuthor(){ArticleAuthorId=1,ArticleId=1},
            new ArticleAuthor(){ArticleAuthorId=2,ArticleId=2},
            new ArticleAuthor(){ArticleAuthorId=3,ArticleId=3},
            new ArticleAuthor(){ArticleAuthorId=4,ArticleId=4,},
        };



    }
}
