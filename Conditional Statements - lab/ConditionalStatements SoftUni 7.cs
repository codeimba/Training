using System;

public class Program
{
    public static void Main()
    {
        string figure = Console.ReadLine();
        if (figure == "square")
        {
            double lenght = double.Parse(Console.ReadLine());
            double sum = lenght * lenght;
            double roundSquare = Math.Round(sum, 3);
            Console.WriteLine(roundSquare);
        }
        else if (figure == "rectangle")
        {
            double rectengleOne = double.Parse(Console.ReadLine());
            double rectangleTwo = double.Parse(Console.ReadLine());
            double sumRectengle = rectengleOne * rectangleTwo;
            double roundRectangle = Math.Round(sumRectengle, 3);
            Console.WriteLine(roundRectangle);
        }
        else if (figure == "circle")
        {
            double circleOne = double.Parse(Console.ReadLine());
            double circleSum = Math.PI * (circleOne * circleOne);
            double roundCircle = Math.Round(circleSum, 3);
            Console.WriteLine(roundCircle);
        }
        else if (figure == "triangle")
        {
            double triangleOne = double.Parse(Console.ReadLine());
            double triangleTwo = double.Parse(Console.ReadLine());
            double triangleSum = (triangleOne * triangleTwo) / 2;
            double roundTriangle = Math.Round(triangleSum, 3);
            Console.WriteLine(roundTriangle);
        }
    }
}