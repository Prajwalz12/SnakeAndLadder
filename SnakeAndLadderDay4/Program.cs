﻿using System;
using System.Collections.Generic;

namespace UC4
{
    public class Dice
    {
        int user1 = 0;
        int count = 0;
        List<int> countStop1 = new List<int>();
        public void FirstDice()
        {
            Console.WriteLine("User1 starts from position 0");
            while (this.user1 < 100)
            {

                int rand = new Random().Next(1, 7);
                Console.WriteLine($"Dice Roll === {rand}");

                this.countStop1.Add(rand);


                int option = new Random().Next(3);

                if (option == 0)
                {
                    Console.WriteLine("User1 checks for NoPlay");
                    Console.WriteLine($"User1 1 Reach : {this.user1}");

                }
                if (option == 1)
                {
                    Console.WriteLine("User1 checks for Ladder");
                    this.user1 = this.user1 + rand;
                    Console.WriteLine($"User1 1 Reach : { this.user1}");
                }
                if (option == 2)
                {
                    Console.WriteLine("User1 checks for Snake");
                    this.user1 = this.user1 - rand;
                    Console.WriteLine($"User1 1 Reach : { this.user1}");
                }

                if (this.user1 < 0)
                {
                    user1 = 0;
                    Console.WriteLine("User1 starts from position 0");
                }

                this.count++;


            }
        }
        void show()
        {
            Console.WriteLine($"Dies Roll Out {this.countStop1.Count} Times");
            Console.WriteLine($"Winning Position : {this.user1}");
            foreach (int i in this.countStop1)
            {
                Console.Write($"{i},");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Dice obj = new Dice();
                obj.FirstDice();
                obj.show();
            }
        }
    }
}