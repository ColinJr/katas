using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets calculate your string");
            string text;
            string[] numbers;
            int[] rawNumbers;
            int addedNumbers;
            //int[] numbers = new int[] { 1, 3, 5, 7, 9 };
            int stringlength = 0;

            Console.WriteLine("Enter a string of numbers seperated by commas");

            //text = Console.ReadLine();
            text = "0,1,2,5,100";
            numbers = text.Split(',');

            if (text != null)
            {
                rawNumbers = numbers.Select(int.Parse).ToArray();
            }
            else
            {
                rawNumbers = new int[] { 0 };
            }

            addedNumbers = rawNumbers.Sum();

            
            Console.WriteLine("You input the numbers");
            //numbers.ToList().ForEach(i => Console.WriteLine(i.ToString()));
            Console.WriteLine(String.Join(",", rawNumbers));
            Console.WriteLine("_______________________________________________");
            Console.WriteLine("Added together those numbers equal");
            Console.WriteLine(addedNumbers);
        }

    }

}
