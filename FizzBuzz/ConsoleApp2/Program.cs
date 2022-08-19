using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string val =  Console.ReadLine();
            int n = Convert.ToInt32(val);
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) 
              {
                    Console.WriteLine("FizzBuzz");
                }
                else if(i % 5 == 0)
              {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
