using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Calc.__Circumfrence_and_area___Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            CircleCalculations();
        }



        private static void CircleCalculations()
        {
            while (true)
            {
                Console.WriteLine("What is the radius of your circle?");
                if (int.TryParse(Console.ReadLine(), out int radius))
                {
                    Circle circle = new Circle(radius);
                    Console.WriteLine("CIRCUMFERENCE:" + circle.CalculateCircumference());
                    Console.WriteLine("-------------");
                    Console.WriteLine("AREA:" + circle.CalculateArea());
                    Console.WriteLine("=============");

                    while (true)
                    {
                        Console.Write("Do you want to continue?(y/n)");
                        string answer = Console.ReadLine();
                        if (answer == "n")
                        {
                            return;
                        }
                        else if (answer == "y")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input--either y to continue or n to exit:");

                        }
                    }
                }
                else
                {
                    Console.WriteLine("Only input whole numbers:");
                }
            }
        }
    }
}
