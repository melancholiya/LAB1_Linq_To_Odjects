using System;
using System.ComponentModel.Design;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace LAB1
{
    //Command // Logic of executing one db request with output DI IPrinter|Action<string>
     class Output:IOutput
    {
        private IRequests _requests;
        public Output(IRequests requests)
        {
            _requests = requests;
        }

        public void GetAverageValueOfJournals()
        {
            double valueOgJournals = _requests.GetAverageValueOfJournals();
            Console.WriteLine($"Середнє значення тиражу усіх журналів:{valueOgJournals }");
        }

        public void SortSubmissionDate()
        {
            var articles=_requests.SortSubmissionDate();
            Console.WriteLine("Сорутування за датою надходження статті у редакцію:");
            foreach(var item in articles )
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void GetAuthors()
        {
            var authors=_requests.GetAuthors();
            Console.WriteLine("Вивести всіх авторів:");
            foreach(var item in authors)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void MonthlyArticle()
        {
            var monthlyArticle=_requests.MonthlyArticle();
            Console.WriteLine("Статті, які виходять щомісяця:");
            foreach(var item in monthlyArticle)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public void GetWeeklyAuthors()
        {
            var weeklyAuthors = _requests.GetWeeklyAuthors();
            Console.WriteLine("Вивести список всіх авторів, які писали статті в журналах, що виходять щотижня:");
            foreach(var item in weeklyAuthors)
            {
                Console.WriteLine(item.ToString());
            }
        }





    }
}
