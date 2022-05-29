using System;

namespace ConsoleApp2
{
	class Program
	{
		static void Main()
		{
			double radius;
			double result;
			double roundedResult;
			double integralPartOfResult;

			Console.WriteLine("-- Program to Calculate Sphere Volume --");

			Console.Write("Enter the radius: ");

			radius = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("The number we entered : " + radius);

			result = (4 * 3.14 * radius * radius * radius) / 3;

			Console.WriteLine("Result: " + result);

			roundedResult = Math.Round(result, 2);

			Console.WriteLine("Two digits after the comma: " + roundedResult);

			integralPartOfResult = Math.Truncate(result);

			Console.WriteLine("İnteger part: " + integralPartOfResult);
		}
	}
}
