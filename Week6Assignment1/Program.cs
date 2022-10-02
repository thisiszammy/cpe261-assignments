// See https://aka.ms/new-console-template for more information

using Week6Assignment1;

Shape[] shapes = new Shape[]
{
    new Triangle
    {
        Height = 5,
        Width = 10
    },
    new Rectangle
    {
        Height = 15,
        Width =2
    },
    new Circle(12)
};

double[] shapeAreas = new double[]
{
    shapes[0].CalculateSurface(),
    shapes[1].CalculateSurface(),
    shapes[2].CalculateSurface()
};

for(int i = 0; i < shapes.Length; i++)
{
    Console.WriteLine("{0}, Area:{1:F2}", shapes[i].ToString(), shapeAreas[i]);
}