//  Author      :   Michael Jay C. Zamoras (21-3810-150)
//  Timestamp   :   2022-09-06 16:19
//  Framework   :   .NET 6 (simplified boilerplate code of C# console apps) refer to https://aka.ms/new-console-template

using Week3Assignment1.entities;

string? command = string.Empty;

while(command != null)
{
    start:
    Console.WriteLine("[Simple Shape Calculator]");
    Console.WriteLine("1.Compute the Area of A Circle");
    Console.WriteLine("2.Compute the Volume of a Cube");
    Console.Write("Input Selection[Number]: ");
    command = Console.ReadLine();

    float x = 3.5F;

    switch (command)
    {
        case "1":
            computeAreaCircle:
            double radius;
            Console.WriteLine("\n\n[Simple Shape Calculator//AreaCircle]");
            Console.Write("Enter Circle's Radius: ");
            var _radius = Console.ReadLine();

            if(!double.TryParse(_radius, out radius))
            {
                Console.WriteLine("Invalid Input! Must input a valid number!\n\n");
                goto computeAreaCircle;
            }

            Circle circle = new Circle(radius, ShapeTypeEnum.CIRCLE);

            Console.WriteLine("Circle's Area: {0:F2}", circle.Area);
            Console.WriteLine("[More Details]");
            Console.WriteLine(circle.ToString() + "\n\n");

            break;
        case "2":
            computeVolumeCube:
            double side;
            Console.WriteLine("\n\n[Simple Shape Calculator//VolumeCube]");
            Console.Write("Enter Cube's Side Length: ");
            var _side = Console.ReadLine();

            if (!double.TryParse(_side, out side))
            {
                Console.WriteLine("Invalid Input! Must input a valid number!\n\n");
                goto computeVolumeCube;
            }

            Cube cube = new Cube(side, ShapeTypeEnum.CUBE);

            Console.WriteLine("Cube's Volume: {0:F2}", cube.Volume);
            Console.WriteLine("[More Details]");
            Console.WriteLine(cube.ToString() + "\n\n");

            break;
        default:
            if (command == null) return;
            Console.WriteLine("Invalid Selection!\n\n");
            goto start;
    }


}