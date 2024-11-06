using System.ComponentModel.DataAnnotations;
using System.Formats.Asn1;

namespace CCAD16_Assignment1_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double squareLength = 5.5;
            double squareWidth = 5.5;
            double rectangleLength = 12;
            double rectangleWidth = 20;
            double triangleBase = 25;
            double triangleHeight = 15;

            double squareResult = SquareArea(squareLength * squareWidth);
            Console.WriteLine(squareResult);

            double rectangleResult = RectangleArea(rectangleLength * rectangleWidth);
            Console.WriteLine(rectangleResult);

            double triangleResult = TriangleArea(0.5 * (triangleBase * triangleHeight));
            Console.WriteLine(triangleResult);
        }

        //method to calculate area of a square
        static double SquareArea(double length)
        {
            double area = length;
            return area;
        }

        //method to calculate area of a rectangle
        static double RectangleArea(double length)
        {
            double area = length;
            return area;
        }

        //method to calculate area of a triangle
        static double TriangleArea(double length)
        {
            double area = length;
            return area;
        }
    }
}
