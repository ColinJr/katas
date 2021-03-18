using System;

namespace _31621KataFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            for (int num = 0; num <= 100; num++ )
            {
                if (num % 3 == 0 && num % 5 ==0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (num % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (num % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                Console.WriteLine(num);

                };
            };
        }
    }
}
