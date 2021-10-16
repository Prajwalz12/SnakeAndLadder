using System;
using System.Collections.Generic;

namespace SnakeAndLadder
{
    class Dice
    {
        int user1 = 0;
        int count = 1;
        int user2 = 0;
        List<int> countStop1 = new List<int>();
        List<int> countStop2 = new List<int>();


        void firstDice()
        {
            while (this.user1 < 100)
            {
                Random random = new Random();
                int rand = random.Next(1, 7);
                Console.WriteLine($"Dies Roll ::::: {rand}");
                this.countStop1.Add(rand);


                ////////////Code for ladder
                ///

                int option = new Random().Next(3);

                if (option == 0)
                {
                    Console.WriteLine("User1 checks for NoPlay");
                    Console.WriteLine($"User1 Reach : {this.user1}");

                }
                if (option == 1)
                {
                    Console.WriteLine("User1 checks for Ladder");
                    this.user1 = this.user1 + rand;
                    Console.WriteLine($"User1 Reach : { this.user1}");
                    firstDice();
                }
                if (option == 2)
                {
                    Console.WriteLine("User1 checks for Snake");
                    this.user1 = this.user1 - rand;
                    Console.WriteLine($"User1 Reach : { this.user1}");
                }

                if (this.user1 < 0)
                {
                    user1 = 0;
                    Console.WriteLine("User1 starts from position 0");
                }

                while (this.user1 > 100)
                {
                    Console.WriteLine($"Greater than 100 Dies was : {this.countStop1[this.countStop1.Count - 1]}");
                    this.user1 = this.user1 - this.countStop1[this.countStop1.Count - 1];
                    Console.WriteLine($"After Greater than 100 Position Will : {this.user1}");
                    break;
                }


                while (this.user1 == 100)
                {
                    Console.WriteLine(":::::::::::::::::::::::Winner is USER 1:::::::::::::::::::::::::::");
                    break;

                }

                this.count++;

                if (this.count % 2 == 0)
                {
                    secondDice();
                    break;
                }
            }
        }
        void secondDice()
        {
            while (this.user2 < 100)
            {
                Random random = new Random();
                int rand = random.Next(1, 7);
                this.countStop2.Add(rand);
                Console.WriteLine($"Dies Roll ::::: {rand}");

                ////////////Code for ladder and Snake
                int option = new Random().Next(3);


                if (option == 0)
                {
                    Console.WriteLine("User2 checks for NoPlay");
                    Console.WriteLine($"User2 Reach : {this.user2}");

                }
                if (option == 1)
                {
                    Console.WriteLine("User2 checks for Ladder");
                    this.user2 = this.user2 + rand;
                    Console.WriteLine($"User2 Reach : { this.user2}");
                    secondDice();
                }
                if (option == 2)
                {
                    Console.WriteLine("User2 checks for Snake");
                    this.user2 = this.user2 - rand;
                    Console.WriteLine($"User2 Reach : { this.user2}");
                }

                if (this.user2 < 0)
                {
                    user2 = 0;
                    Console.WriteLine("User2 starts from position 0");
                }

                while (this.user2 > 100)
                {
                    Console.WriteLine($"Greater than 100  Dies was : {this.countStop2[this.countStop2.Count - 1]}");
                    this.user2 = this.user2 - this.countStop2[this.countStop2.Count - 1];
                    Console.WriteLine($"After Greater than 100 Position Will : {this.user2}");
                    break;
                }


                while (this.user2 == 100)
                {
                    Console.WriteLine(":::::::::::::::::::::::Winner is USER 2:::::::::::::::::::::::::::");
                    break;
                    show();
                }
                this.count++;


                if (this.count % 2 != 0)
                {
                    firstDice();
                    break;
                }


            }

        }
        void show()
        {
            Console.WriteLine($"Dies Roll Out from User 1 :::::: {this.countStop1.Count} ::::: Times");
            Console.WriteLine($"Dies Roll Out from User 2 :::::: {this.countStop2.Count} ::::: Times");
            foreach (int i in this.countStop1)
            {
                Console.Write($"{i},");
            }
        }
        /// <summary>
        /// ////////////////////////Ladder snake
        /// </summary>
        /// ////////////////////////Ladder snake
        static void Main(string[] args)
        {

            Dice obj = new Dice();
            obj.firstDice();
            obj.show();
        }

    }
}
