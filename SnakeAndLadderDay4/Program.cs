using System;

namespace UC3
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            Console.WriteLine("User1 start at positon 0");
            var random = new Random().Next(1, 7);
            Console.WriteLine("Dice no is : " + random);

            int Option = new Random().Next(3);
            Console.WriteLine("Player checks for option : " + Option);

            if (Option == 0)
            {
                Console.WriteLine("Player checks for noplay - Position is : " + count);
            }
            else if (Option == 1)
            {
                Console.WriteLine("Player checks for ladder - Position is :" + count + random);
            }
            else
            {
                Console.WriteLine("Player checks for snake - Position is : " + (count - random));
            }


        }
    }
}