using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Activities
{
    public static class ProblemSet1
    {
        public static void Run()
        {
            int grade;
            Console.WriteLine("\n======================\nRunning Week 2: Problem Set 1\n======================");
            
            start:
                Console.Write("PLease Enter Student's Grade:");
                var _grade = Console.ReadLine();

                if (!int.TryParse(_grade, out grade)) goto error;

                string message = "Student Has Received A Grade Rating of: [{0}]";
                char rating = '\0';

                if (grade < 0 || grade > 100) goto error;

                if (grade <= 49) rating = 'F';
                else if (grade <= 59) rating = 'D';
                else if (grade <= 69) rating = 'C';
                else if (grade <= 79) rating = 'B';
                else if (grade <= 100) rating = 'A';

                Console.WriteLine(message, rating);

                return;

            error:
                Console.WriteLine("Invalid Input! Please Try Again! (Accepted Input Range [0 - 100])");
                goto start;

        }
    }
}
