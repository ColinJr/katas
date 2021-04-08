using System;

namespace _031821KataPaintCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's find how much paint is needed for your room!");

            float areaPerCan;
            float roomLength;
            float roomWidth;
            float roomHeight;
            int numOfObstructions;
            float totalObstructionArea = 0;


            string correct;

            do
            {
                Console.WriteLine("How many square feet can each bucket of your chosen paint cover?");
                areaPerCan = (float)Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("What is your room's length in feet?");
                roomLength = (float)Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("What is your room's width in feet?");
                roomWidth = (float)Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("What is your room's height?");
                roomHeight = (float)Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("So your room is " + roomLength + " feet long, " + roomWidth + " feet wide, and " + roomHeight + " feet tall?");
                Console.WriteLine("(yes/no)");
                correct = Console.ReadLine().ToLower();

            }
            while (correct != "yes");


            do
            {
                Console.WriteLine("How many doorways, windows or other paint free sections are there?");
                numOfObstructions = Convert.ToInt32(Console.ReadLine());

                for (int currentObstruction = 1; currentObstruction <= numOfObstructions; currentObstruction++)
                {
                    Console.WriteLine("Door/Window #" + currentObstruction);
                    Console.WriteLine("What is the length of the " + currentObstruction + "th door/window, in feet?");
                    float obstructionLength = (float)Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("What is the height of the " + currentObstruction + "th door/window, in feet?");
                    float obstructionHeight = (float)Convert.ToDouble(Console.ReadLine());
                    float obstructionArea = obstructionHeight * obstructionLength;
                    totalObstructionArea = totalObstructionArea + obstructionArea;
                }
                Console.WriteLine("Was all that Correct? (yes/no)");
                correct = Console.ReadLine().ToLower();
            }
            while (correct != "yes");


            float ceilingArea = roomLength * roomWidth;
            float walls13Area = 2 * roomLength * roomHeight;
            float walls24Area = 2 * roomWidth * roomHeight;
            float totalPaintableArea = ceilingArea + walls13Area + walls24Area;
            Console.WriteLine(totalPaintableArea + " is the total area of all the walls and ceiling");



            Console.WriteLine(totalObstructionArea + " is the total area we don't need to paint, due to doors/windows");
            totalPaintableArea = totalPaintableArea - totalObstructionArea;
            float numOfCans = (int)Math.Ceiling(totalPaintableArea / areaPerCan);
            Console.WriteLine("Your room has " + totalPaintableArea + " square feet of surface in need of paint. And painting it will take " + numOfCans + " cans of paint");
        }
    }

}
if (!string.IsNullOrWhiteSpace(numbers))
{
    var splits = numbers.Split(new char[] { ',', '\n' });

    foreach (string number in splits)
    {
        int newNumber = 0;

        try
        {
            newNumber = Convert.ToInt32(number);
        }
        catch (FormatException)
        {
            newNumber = 0;
        }

        if (newNumber < 0)
        {
            throw new NegativesNotAllowedException();
        }

        sum += newNumber;
    }
}

return sum;
	}