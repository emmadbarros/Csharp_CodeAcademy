/*
 In the game Exquisite Corpse, participants draw either a head, body, or feet of a creature. The players don’t know how their part of the body connects to the other two, until the drawing is finished and revealed.

For this project, you’ll write a program that mimics the Exquisite Corpse game. Using methods, you’ll be able to randomly combine different parts of ASCII characters so they create a new creature.
*/

using System;

namespace ExquisiteCorpse
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildACreature("ghost", "monster", "bug");
            Console.WriteLine("\nRandom Mode:\n");
            RandomMode();
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
        static void BuildACreature(string head, string body, string feet)
        {
            //head
            switch(head)
            {
                case "ghost":
                    GhostHead();
                    break;
                case "bug":
                    BugHead();
                    break;
                case "monster":
                    MonsterHead();
                    break;
            }

            //body
            switch(body)
            {
                case "ghost":
                    GhostBody();
                    break;
                case "bug":
                    BugBody();
                    break;
                case "monster":
                    MonsterBody();
                    break;
            }

            //feet
            switch(feet)
            {
                case "ghost":
                    GhostFeet();
                    break;
                case "bug":
                    BugFeet();
                    break;
                case "monster":
                    MonsterFeet();
                    break;
            }
        }

        static void RandomMode()
        {
            Random randomNumber = new Random();

            int head = randomNumber.Next(1, 4);
            int body = randomNumber.Next(1, 4);
            int feet = randomNumber.Next(1, 5);


            //head
            switch (head)
            {
                case 1:
                    GhostHead();
                    break;
                case 2:
                    BugHead();
                    break;
                case 3:
                    MonsterHead();
                    break;
            }

            //body
            switch (body)
            {
                case 1:
                    GhostBody();
                    break;
                case 2:
                    BugBody();
                    break;
                case 3:
                    MonsterBody();
                    break;
            }

            //feet
            switch (feet)
            {
                case 1:
                    GhostFeet();
                    break;
                case 2:
                    BugFeet();
                    break;
                case 3:
                    MonsterFeet();
                    break;
            }
        }
    }
}
