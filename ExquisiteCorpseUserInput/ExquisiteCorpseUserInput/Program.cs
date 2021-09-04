using System;

namespace ExquisiteCorpseUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StartingMode();
            }
            finally
            {
                Console.WriteLine("Press any key to finish");
                Console.ReadKey();
            }
        }

        static void StartingMode()
        {
            Console.WriteLine("Welcome to the game, select a game mode (choose a number):\n1- Create Creature Manually\n2- Random Mode!");

            //with int.TryParse
            if (!int.TryParse(Console.ReadLine(), out int gameMode))
            {
                Console.WriteLine("Invalid character(s), only integers from 1-2 are allowed.");
                return;
            }

            if (gameMode < 1 || gameMode > 2)
            {
                Console.WriteLine("Invalid character(s), only integers from 1-2 are allowed.");
                return;
            }

            switch (gameMode)
            {
                case 1:
                    CreateCreatureManually();
                    break;
                case 2:
                    RandomMode();
                    break;
            }
        }

        static void CreateCreatureManually()
        {
            string tryAgain = "Invalid character(s), only integers from 1-3 are allowed. Try again:";

            //Prompt user - head
            GenerateBodyPart("head");

            //with int.TryParse
            if (!int.TryParse(Console.ReadLine(), out int headNum))
            {
                Console.WriteLine(tryAgain);
                return;
            }

            if (headNum < 1 || headNum > 3)
            {
                Console.WriteLine(tryAgain);
                return;
            }

            //Prompt user - body
            GenerateBodyPart("body");

            //with int.TryParse
            if (!int.TryParse(Console.ReadLine(), out int bodyNum))
            {
                Console.WriteLine(tryAgain);
                return;
            }

            if (bodyNum < 1 || bodyNum > 3)
            {
                Console.WriteLine(tryAgain);
                return;
            }

            //Prompt user - feet
            GenerateBodyPart("feet");

            if (!int.TryParse(Console.ReadLine(), out int feetNum))
            {
                Console.WriteLine(tryAgain);
                return;
            }

            if (feetNum < 1 || feetNum > 3)
            {
                Console.WriteLine(tryAgain);
                return;
            }

            SwitchCase(headNum, bodyNum, feetNum);
        }

        static void GenerateBodyPart(string bodyPart)
        {
            Console.WriteLine($"Which monster do you want to generate for the {bodyPart} (choose a number)?:\n1- monster\n2- ghost\n3- bug");
        }

        //Provided Methods
        static void GhostHead()
        {
            Console.WriteLine("     ..-..");
            Console.WriteLine("    ( o o )");
            Console.WriteLine("    |  O  |");
        }

        static void GhostBody()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
        }

        static void GhostFeet()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    '~~~~~'");
        }

        static void BugHead()
        {
            Console.WriteLine("     /   \\");
            Console.WriteLine("     \\. ./");
            Console.WriteLine("    (o + o)");
        }

        static void BugBody()
        {
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
        }

        static void BugFeet()
        {
            Console.WriteLine("     v   v");
            Console.WriteLine("     *****");
        }

        static void MonsterHead()
        {
            Console.WriteLine("     _____");
            Console.WriteLine(" .-,;='';_),-.");
            Console.WriteLine("  \\_\\(),()/_/");
            Console.WriteLine("　  (,___,)");
        }

        static void MonsterBody()
        {
            Console.WriteLine("   ,-/`~`\\-,___");
            Console.WriteLine("  / /).:.('--._)");
            Console.WriteLine(" {_[ (_,_)");
        }

        static void MonsterFeet()
        {
            Console.WriteLine("    |  Y  |");
            Console.WriteLine("   /   |   \\");
            Console.WriteLine("   \"\"\"\" \"\"\"\"");
        }

        //Custom Methods

        //example call:
        //BuildACreature("bug", "monster", "ghost");
        //this will return an ASCII creature
        //with a bug head, monster body, ghost feet

        static void RandomMode()
        {
            Random randomNumber = new Random();

            int head = randomNumber.Next(1, 4);
            int body = randomNumber.Next(1, 4);
            int feet = randomNumber.Next(1, 4);

            Console.WriteLine("Here's your random creature!");
            SwitchCase(head, body, feet);
        }

        //Custom method to store switch statement
        static void SwitchCase(int head, int body, int feet)
        {
            //head
            switch (head)
            {
                case 1:
                    MonsterHead();
                    break;
                case 2:
                    GhostHead();
                    break;
                case 3:
                    BugHead();
                    break;
            }

            //body
            switch (body)
            {
                case 1:
                    MonsterBody();
                    break;
                case 2:
                    GhostBody();
                    break;
                case 3:
                    BugBody();
                    break;
            }

            //feet
            switch (feet)
            {
                case 1:
                    MonsterFeet();
                    break;
                case 2:
                    GhostFeet();
                    break;
                case 3:
                    BugFeet();
                    break;
            }

        }
    }
}
