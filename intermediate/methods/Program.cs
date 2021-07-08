using System;
using System.Collections.Generic;
using System.IO;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            var result = int.TryParse("123a", out number);
            if(result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion failed");

        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
        }

        static void UsePoints()
       {
            try
            {
                var point = new Point(10, 20);
                point.Move(point);
                Console.WriteLine(point.X);
                Console.WriteLine(point.Y);

                point.Move(100, 200);
                Console.WriteLine(point.X);
                Console.WriteLine(point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured.");
            }
        }
    }
}
