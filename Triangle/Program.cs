using System;
using System.Collections.Generic;

namespace Triangle
{
  public class TriangleTracker
  {
    static void Main()
    {
      Console.WriteLine("Enter first side: ");
      int Side1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter second side: ");
      int Side2 = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter third side: ");
      int Side3 = int.Parse(Console.ReadLine());
      Triangle currentTriangle = new Triangle (Side1, Side2, Side3);
      Console.WriteLine(currentTriangle.TriangleType());
    }
  }
  public class Triangle
  {
    public int Side1;
    public int Side2;
    public int Side3;
    public Triangle(int side1, int side2, int side3)
    {
      Side1 = side1;
      Side2 = side2;
      Side3 = side3;
    }
    public string TriangleType()
    {
      if (Side1>(Side2+Side3)|| Side2 > (Side1+Side3) || Side3 > (Side2+Side1))
      {
        return("This is not a triangle.");
      }
      else if (Side1 == Side2 && Side2 == Side3)
      {
        return("This is an equilaterial triangle.");
      }
      else if (Side1 == Side2 || Side2 == Side3 || Side1 == Side3)
      {
        return("This is an isosceles triangle.");
      }
      else
      {
        return("This is a scalene triangle.");
      }
    }
  }
}