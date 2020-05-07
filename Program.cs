using System;

namespace learnFromHome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment 1. This program calculate the quadratic equation");
            // Declaring of variables
            double d, x1, x2;
            Console.WriteLine("Enter integer value of a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter integer value of b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter integer value of c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            // Declaring the formula for d
            d = b*b - 4*a*c;
            // Calculating and checking the conditions
            if (d==0)
            {
                x1 = -b / 2.0*a;
                x2=x1;
                Console.WriteLine("The values of x1 and x2 are equal with value: {0}", x1);
            } else if (d > 0)
            {
                Console.WriteLine("The two root are diff:");
                x1=(-b+Math.Sqrt(d))/(2*a);
                x2=(-b-Math.Sqrt(d))/(2*a);
                Console.WriteLine("The values of x1 and x2 are: {0}, {1}", x1,x2);
            } else
            {
                Console.WriteLine("The values of x1 and x2 are imaginary or no solution ");
            }
            Console.WriteLine(" ");

            // // Assignment 2
            Console.Write("Assignment 2.");
            Console.WriteLine(" This program convert Fahrenheit to celsius");
            // User input
            Console.Write("Enter the Fahranheit value to covert: ");
            double Fahrenheit = double.Parse(Console.ReadLine());
            double result = ConvertTemperatureToCelsius(Fahrenheit);
            Console.WriteLine("The Fahranheit equvalent of the value is: {0:##.###} ",result);

            // // Assignment 3
            // This program check if user input is a palindrome
            Console.Write("Assignment 3.");
            Console.WriteLine(" This program check if a user input is a palindrome");
            // Declaring of variables
            int userInput, remainder, n;
            int isPalin = 0;
            Console.Write("Enter an integer: ");
            userInput = Convert.ToInt32(Console.ReadLine());
            n = userInput;
            // Compute the input integer
            while (n != 0)
            {
                remainder = n % 10;
                isPalin = isPalin * 10 + remainder; 
                n /= 10;
            }
            // This check if the user input is a palindrome
            if (isPalin == userInput)
            {
                Console.WriteLine("The inputed number: {0}, is a palindrome.", isPalin);
            }
            else
            {
                Console.WriteLine("The inputed number: {0}, is not a palindrome.", isPalin);
            }
            
        }
    static double ConvertTemperatureToCelsius(double fahrenheitF){
        double celsiusF = (fahrenheitF - 32)* 5/9;
        return celsiusF;
    }
    }
}

