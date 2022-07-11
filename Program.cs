// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        var shapes = new List<Shape>{ new Square(6), new Circle(2), new Triangle(4, 5), new Rectangle(4, 5) };
        shapes.Sort();

        foreach (var shape in shapes)
            Console.WriteLine(shape + "\n");
    }
}
abstract class Shape : IComparable<Shape>
{
    public abstract double CalcArea();

    public int CompareTo(Shape other)
    {
        double area = CalcArea();
        return area.CompareTo(other.CalcArea());
    }
}
class Square : Shape
{
    private double Height;

    public Square(double side)
    {
        Height = side;
    }

    public override double CalcArea()
        => Math.Pow(Height, 2);
    public override string ToString()
        => $"[Square]\nHeight: {Height}\nArea: {CalcArea()}";
}

class Rectangle : Shape
{
    private double Length, Breadth;

    public Rectangle(double length, double breadth)
    {
        Length = length;
        Breadth = breadth;
    }

    public override double CalcArea()
        => Length * Breadth;
    public override string ToString()
        => $"[Rectangle]\nLength: {Length}\nBreadth: {Breadth}\nArea: {CalcArea()}";
}

class Triangle : Shape
{
    private double Bredth, Height;

    public Triangle(double bredth, double height)
    {
        Height = height;
        Bredth = bredth;
    }

    public override double CalcArea()
        => (Bredth * Height) / 2;

    public override string ToString()
        => $"[Triangle]\nBase: {Bredth}\nHeight: {Height}\nArea: {CalcArea()}";
}
    
class Circle : Shape
{
    private double Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalcArea()
        => Math.PI * Math.Pow(Radius, 2);
    public override string ToString()
        => $"[Circle]\nRadius: {Radius}\nArea: {CalcArea()}";
}