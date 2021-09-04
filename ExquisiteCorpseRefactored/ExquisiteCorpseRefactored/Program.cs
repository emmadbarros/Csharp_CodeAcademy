/*
 **** REFACTORED ****
 In the game Exquisite Corpse, participants draw either a head, body, or feet of a creature. The players don’t know how their part of the body connects to the other two, until the drawing is finished and revealed.

For this project, you’ll write a program that mimics the Exquisite Corpse game. Using methods, you’ll be able to randomly combine different parts of ASCII characters so they create a new creature.
*/

using System;

namespace ExquisiteCorpseRefactored
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creature 1:");
            RandomMode();
            Console.WriteLine("Creature 2:");
            RandomMode();
            Console.WriteLine("Creature 3 using strings as arguments:");
            BuildACreature("bug", "monster", "ghost");

            Console.WriteLine("With optional parameters: ");
            BuildACreature("bug", "monster");
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
        static void BuildACreature(string head = "monster", string body = "ghost", string feet = "bug")
        {
            int headNum = TranslateToNumber(head);
            int bodyNum = TranslateToNumber(body);
            int feetNum = TranslateToNumber(feet);

            SwitchCase(headNum, bodyNum, feetNum);
        }

        static void RandomMode()
        {
            Random randomNumber = new Random();

            int head = randomNumber.Next(1, 4);
            int body = randomNumber.Next(1, 4);
            int feet = randomNumber.Next(1, 5);


            SwitchCase(head, body, feet);
        }

        //Custom method to store switch statement
        static void SwitchCase(int head, int body, int feet)
        {
            //head
            switch(head)
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
            switch(body)
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
            switch(feet)
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

        //TranslateToNumber method
        static int TranslateToNumber(string creature)
        {
            switch(creature)
            {
                case "ghost":
                    return 1;
                case "bug":
                    return 2;
                case "monster":
                    return 3;
                default:
                    return 1;
            }
        }

    }
}
