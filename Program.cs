using System;

namespace learnFromHome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment one");
            IsDivisible(); // Invoking IsDivisible method
            Console.WriteLine("Assignment two");
            ConvertToDecimal();// Invoking ConvertToDecimal method

            Console.ReadKey();
        }
        //This program print numbers that are not divisible by 3 and 7.
        public static void IsDivisible()
        {
            Console.Write("Enter any integer value:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The following numbers are not divisible by 3 & 7 simultaneously");
            for (int i = 0; i <= number; i++)
            {
                if ((i % 3 != 0) && (i % 7 != 0))
                {
                    
                    Console.WriteLine(i);
                }

            }
        }
        //A program to converts a given number from binary to decimal notation
        public static void ConvertToDecimal()
        {
            Console.Write("Enter values containing 0 and 1: ");
            string binNumber = Convert.ToString(Console.ReadLine());
            string binaryNumber = binNumber;
            var sum = 0;
            if (IsBin(binNumber)){
                for (var i = 0; i < binaryNumber.Length; i++)
                {
                    sum = Convert.ToInt32(binaryNumber, 2);
                }
                Console.WriteLine("The binary equivalent of {0} is {1}", binNumber, sum);
            }
            else
            {
                Console.WriteLine("The binary number must be 0 or 1");
            }
            
        }
        //This code validate a binary input has been supplied before evaluation.
        public static bool IsBin(string s)
        {
            foreach (var c in s)
                if (c != '0' && c != '1')
                {
                    return false;
                }
            return true;

        }
    }
}

