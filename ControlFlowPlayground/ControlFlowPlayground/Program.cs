using System;

namespace ControlFlowPlayground
{
    class Program
    {
        static DateTime today = DateTime.Today;
        static DateTime userBirthdate;

        static void Main(string[] args)
        {
            //try-finally: design choice so the user has a chance to admire the cake before the console closing
            try
            {
                //3. Birthday Program!

                //flag
                bool parseSucceed = false;

                while (!parseSucceed)
                {
                    Console.WriteLine("Welcome! Enter your birthdate:");

                    if (!DateTime.TryParse(Console.ReadLine(), out userBirthdate))
                    {
                        Console.WriteLine("Invalid date, please try again.");
                        continue;
                    }
                    else
                    {
                        parseSucceed = true;
                    }
                }

                //or: {userBirthdate: yyyy / MM / dd}
                //Console.WriteLine($"Your birthdate is: {userBirthdate.ToString("dd/MM/yyyy")}");

                if (today.Day == userBirthdate.Day && today.Month == userBirthdate.Month)
                {
                    Console.WriteLine("                     /^\\");
                    Console.WriteLine("           /         (/^\\)     /");
                    Console.WriteLine("      \\   ( \\         \\ /     ( \\     /^\\");
                    Console.WriteLine("     / )   \\ |        _|_      \\ |   |/^\\|");
                    Console.WriteLine("    | /    _|_        | |      _|_    \\ /");
                    Console.WriteLine("    _|_    | |        | |      | |    _|_");
                    Console.WriteLine("    | |    | |        | |      | |    | |");
                    Console.WriteLine("    | |    | |    ****| |******| |    | |");
                    Console.WriteLine("    | |****| |****    | |      | |****| |");
                    Console.WriteLine("   *| |    | |                 | |    | |*****");
                    Console.WriteLine(" *  | |   H  A  P  P  Y               | |      *");
                    Console.WriteLine("*                                               *");
                    Console.WriteLine("| *            B  I  R  T  H  D  A  Y  !      * |");
                    Console.WriteLine("|  *****                                 *****  |");
                    Console.WriteLine("|@      **********             **********      @|");
                    Console.WriteLine("| @   @           *************           @   @ |");
                    Console.WriteLine("|  @@@ @    @                       @    @ @@@  |");
                    Console.WriteLine("|       @@@@ @      @       @      @ @@@@       |");
                    Console.WriteLine(" *            @@@@@@ @     @ @@@@@@            *");
                    Console.WriteLine("  *                   @@@@@                   *");
                    Console.WriteLine("   *****                                 *****");
                    Console.WriteLine("        **********             **********");
                    Console.WriteLine("                  *************");
                }
                else
                {
                    //chunk of code taken from: https://stackoverflow.com/questions/1170257/calculate-days-remaining-to-a-birthday

                    //**
                    DateTime next = userBirthdate.AddYears(today.Year - userBirthdate.Year);

                    if (next < today)
                    {
                        next = next.AddYears(1);
                    }

                    int numDays = (next - today).Days;
                    //**

                    Console.WriteLine("{0} day{1} left until your birthday!", numDays, numDays > 1 ? "s" : "");

                }
            }
            finally
            {
                Console.Write("Press any key to finish");
                Console.ReadKey();
            }
        }
    }
}

/*
**REVIEW**
*
Great job! You just learned about how to create programs that use control flow. Here’s a few of the things we covered:

    - Using if, else if, and else keywords to write conditional statements
    - Writing switch statements for situations where they are many conditions
    - Using ternary operators for shorter conditional statements

Now that you know a few things about control flow, try writing a program that:

    1. Has a user guess a random number between 1-10 and lets them know if they got it correct, are too low, or are too high

    2. Asks users to select their favorite fast food and tells them what type of cat they are (or basically, any kind of Buzzfeed style quiz)

    3. Checks if it’s your birthday. If it is, it will print out a celebratory ASCII banner and if not, it will tell you how many days until your birthday.

 */
