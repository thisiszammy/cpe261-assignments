//  Author      :   Michael Jay C. Zamoras (21-3810-150)
//  Timestamp   :   2022-09-15 01:30
//  Framework   :   .NET 6 (simplified boilerplate code of C# console apps) refer to https://aka.ms/new-console-template

using MidtermProject.Entities;
using Week4Assignment2.Entities;


List<Human> humans = new List<Human>();


string command = string.Empty;

while(command != null)
{
    start:
    Console.WriteLine("[GOD SIMULATOR]");
    Console.WriteLine("1. Create New Human");
    Console.WriteLine($"2. View All Humans ({humans.Count} records)");
    Console.Write("Input Selection[Number]: ");
    command = Console.ReadLine();

    switch (command)
    {

        case "1":
            createHuman:
            Console.WriteLine("\n[Create Human]::[Select Human Type]");
            Console.WriteLine("1. Student");
            Console.WriteLine("2. Worker");
            Console.Write("Input Selection[Number]: ");
            int selection;

            string? firstName, lastName;
            Human newHuman;

            var inp = Console.ReadLine();
            
            if(!int.TryParse(inp, out selection))
            {
                Console.WriteLine("Invalid Selection!\n\n");
                goto createHuman;
            }

            inputFirstName:
            Console.Write("Enter First Name: ");
            firstName = Console.ReadLine();
            if (firstName == null) goto inputFirstName;

            inputLastName:
            Console.Write("Enter Last Name: ");
            lastName = Console.ReadLine();
            if (lastName == null) goto inputLastName;

            switch (selection)
            {
                case 1:
                    inputMark:
                    string? mark;
                    Console.Write("Enter Student's Mark: ");
                    mark = Console.ReadLine();
                    if (mark == null) goto inputMark;
                    newHuman = new Student(firstName, lastName, mark);
                    break;
                case 2:
                    double totalWage, totalHoursWorked;

                    inputTotalWage:
                    Console.Write("Enter Total Wage: ");
                    var _totalWage = Console.ReadLine();
                    if (!double.TryParse(_totalWage, out totalWage)) goto inputTotalWage;

                    inputTotalHoursWorked:
                    Console.Write("Enter Total Hours Worked: ");
                    var _totalHoursWorked = Console.ReadLine();
                    if(!double.TryParse(_totalHoursWorked, out totalHoursWorked)) goto inputTotalHoursWorked;

                    newHuman = new Worker(firstName, lastName, totalWage, totalHoursWorked);
                    break;
                default:
                    Console.WriteLine("Invalid Selection!\n\n");
                    goto createHuman;
            }

            humans.Add(newHuman);
            Console.WriteLine("\nSuccessfully Created New Human!\n");
            goto start;

        case "2":
            Console.WriteLine("\n================== [ALL HUMANS] ==================\n");
            int i = 1;
            foreach(var item in humans)
            {
                Console.WriteLine($"{i}] {item.ToString()}");
                i++;
            }
            Console.WriteLine("\nSuccessfully Loaded Humans!\n");
            goto start;
            break;
        default:
            if (command == null) return;
            Console.WriteLine("Invalid Selection!\n\n");
            goto start;
    }

}