using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            string text;
            int Solution;
            char[] delimiters = new[] { ',', ';', ' ', '\n' };
            //text = "0,1,2,5,100 ";
            //text = "1\n2,3";
            text = "0,1,2,5,100 1\n2,3";

            if (text != null)
            {
                Solution = Add(text, delimiters);
            }
            else
            {
                Solution = 0;
            }
            Console.WriteLine("We are adding the numbers " + String.Join(", ", text.Split(delimiters)));
            Console.WriteLine("Added together those numbers equal " + Solution);
        }
        static int Add(string text, char[] delimiters)
        {
            return text.Split(delimiters).Select(int.Parse).ToArray().Sum();
        }
    }

}
