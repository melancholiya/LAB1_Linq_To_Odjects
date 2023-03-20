using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LAB1
{
    class Run:IRun
    {
        private readonly IOutput _output;
        public Run(IOutput output)
        {
            _output = output;
        }
        public void Runner()
        {
            var dictionary = new Dictionary<CommandNumber, Action>()
            {
                { CommandNumber.SortSubmissionDate, () => _output.SortSubmissionDate() },
                { CommandNumber.GetAuthors, () => _output.GetAuthors() },
                { CommandNumber.GetWeeklyAuthors, () => _output.GetWeeklyAuthors() },
                { CommandNumber.GetAverageValueOfJournals, () => _output.GetAverageValueOfJournals() },
                { CommandNumber.MonthlyArticle, () => _output.MonthlyArticle() }
            };

            Console.WriteLine("Enter a command:");
            string input = Console.ReadLine();
            try
            {
                CommandNumber command = (CommandNumber)Enum.Parse(typeof(CommandNumber), input);
                dictionary[command].Invoke();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid input.");
            }
        }

    }
}
