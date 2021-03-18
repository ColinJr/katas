using System;

namespace _031821KataPaintCalc
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Let's find how much paint is needed for your ceiling!");

            Console.WriteLine("How many square feet can each bucket of your chosen paint cover?");
            float areaPerCan = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("What is your room's length in feet?");
            float roomLength = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your room's width in feet?");
            float roomWidth = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("What is your room's height?");
            //int roomHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("So your room is " + roomLength + " feet by " + roomWidth + " feet?");
            float ceilingArea = roomLength*roomWidth;
            float numOfCans = (int)Math.Ceiling(ceilingArea/areaPerCan);
            Console.WriteLine("Your ceiling is " + ceilingArea + " square feet. And needs " + numOfCans + " buckets of paint");
        }
    }
}
