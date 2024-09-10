// See https://aka.ms/new-console-template for more information
using MindboxLib;
class Program
{
    static void Main()
    {
        IFigure figure1 = new Circle(5);
        IFigure figure2 = new Triangle(3, 4, 5);

        Console.WriteLine($"Area of circle: {figure1.GetArea()}");
        Console.WriteLine($"Area of triangle: {figure2.GetArea()}");

        TestTriangle(figure1);
        TestTriangle(figure2);
    }
    private static void TestTriangle(IFigure figure) 
    {
        //var pri = figure is Triangle triangle;
        var triangle = figure as Triangle;
        if (triangle != null) {
            if (triangle.IsRightTriangle())
            {
                Console.WriteLine($"The triangle with sides {triangle.Side1}, {triangle.Side2}, {triangle.Side3}  is a right triangle.");
            }
            else
            {
                Console.WriteLine($"The triangle with sides {triangle.Side1}, {triangle.Side2}, {triangle.Side3}  is not a right triangle.");
            }
        }
        else 
        {
            //  ??
           // Console.WriteLine();
        }
    }
}
