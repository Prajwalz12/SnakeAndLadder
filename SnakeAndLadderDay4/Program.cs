using System;

namespace UC2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User1 start at positon 0");
            Random random = new Random();
            Console.WriteLine("Dice no is : " + random.Next(1, 7));
        }
    }
}