// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        Program a = new Program();
        a.Square();
        a.Rectangle();
        a.Triangle();
        a.Circle();
        
        /*
        var shapes = new List<Shape>{ 
            new Square(side),
            new Circle(radius),
            new Triangle(base, height) };
        shapes.Sort();
         */

        Console.ReadKey();
    }

    public void Square()
    {
        Console.Write("Enter side Square: ");
        float side = float.Parse(Console.ReadLine());
        Console.WriteLine("Area of Square is: {0}", (float)Math.Pow(side, 2));
    }

    public void Rectangle()
    {
        Console.Write("Enter length Rectangle: ");  
        float length = float.Parse(Console.ReadLine());  
        Console.Write("Enter breadth Rectangle: ");  
        float breadth = float.Parse(Console.ReadLine());
        Console.WriteLine("Area of Rectangle is: {0}", length * breadth);  
    }

    public void Triangle()
    {
        Console.Write("Enter breadth Triangle: ");  
        float bredth = float.Parse(Console.ReadLine());  
        Console.Write("Enter height Triangle: ");  
        float height = float.Parse(Console.ReadLine());
        Console.WriteLine("Area of Triangle is: {0}", (bredth * height) / 2);  
    }
    
    public void Circle()
    {
        Console.Write("Enter radius of Circle: ");  
        float radius = float.Parse(Console.ReadLine());
        Console.WriteLine("Area of Circle is: {0}", Math.PI * (float)Math.Pow(radius, 2));  
    }
    
}