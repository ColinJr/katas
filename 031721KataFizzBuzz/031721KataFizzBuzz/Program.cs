using System;

namespace _031721KataFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++){
                string fizzBuzz = "";

                if (i % 3 == 0) {
                    fizzBuzz += "Fizz";
                };
                if (i % 5 == 0) {
                    fizzBuzz += "Buzz";
                };
                if (fizzBuzz == ""){
                    fizzBuzz += i;
                };
                Console.WriteLine(fizzBuzz);
            }
        }
    }
}
