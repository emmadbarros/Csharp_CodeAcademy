using System;

namespace MoneyMaker
{
    class Program
    {
        //declare and initialize coin variables
        static int goldCoin = 10;
        static int silverCoin = 5;
        //bronze coin = 1 so it equals the remaining amount at the end

        //declare and initialize amount variable for user input
        //I chose int here because we can't really have 1.2 cents;
        static int amount = 0;

        static double remainingAmount = 0;

        public static double goldCoinConverter()
        {
            double goldCoins = Math.Floor((double)amount / goldCoin);

            remainingAmount = amount % goldCoin;

            return goldCoins;
        }

        public static double silverCoinConverter()
        {
            double silverCoins = Math.Floor(remainingAmount / silverCoin);

            remainingAmount = amount % silverCoin;

            return silverCoins;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");

            //flag variable for user input
            bool parseSucceed = false;

            //get user input
            while (!parseSucceed)
            {
                Console.WriteLine("Enter an amount to convert to coins:");
                if (!int.TryParse(Console.ReadLine(), out amount))
                {
                    Console.WriteLine("Invalid characters, try again.");
                }
                else
                {
                    if (amount < 0)
                    {
                        Console.WriteLine("The amount to convert must be greater than 0, try again.");
                        continue;
                    }
                    parseSucceed = true;
                }
            }

            Console.WriteLine($"{amount} cent{(amount > 1 ? "s" : "")} is equal to...\nGold coins: {goldCoinConverter()}\nSilver coins: {silverCoinConverter()}\nBronze coins: {remainingAmount}");
        }
    }
}

/*
 You have three types of coins:

    - A bronze coin is worth 1 cent
    - A silver coin is worth 5 cents
    - A gold coin is worth 10 cents

What is the minimum number of coins that equals 98 cents?

It’s a hard question to answer in your head, but it’s a fun problem to solve with programming. In this project you’ll use C# to build a Money Maker: a program in which a user enters an amount and gets the minimum number of coins that equal that value.

For example, 16 cents could be:

    - 16 bronze coins,
    - 3 silver coins and 1 bronze coin, or
    - 1 gold coin, 1 silver coin, 1 bronze coin

We’d like the last option because it uses the fewest coins.

This project will get you comfortable with division (/), rounding down (Math.Floor()), and modulo (%): You can find how many coins “fit” into an amount by dividing the amount by the coin value, rounding down, and finding the remainder.

Let’s walk through an example:

1- The user enters 15 cents. A gold coin is 10 cents, so 1.5 gold coins fit into the total.

    goldCoinsIn15Cents = 15 / 10; // equals 1.5

2- But we can’t divide coins in half, so instead, we round down to the nearest whole number:

    actualGoldCoins = Math.Floor( 15 / 10 ); // equals 1

3- You can find the remainder using modulo:

    double remainder = 15 % 10; // equals 5

4- Using the remainder, repeat the process with the smaller coins.

**OPTIONAL CHALLENGES**

    a) instead of using int in the conversion, use double. The program will not work if the user enters a decimal, like 16.2 cents. Using type conversion or a Math method, round down their input to the nearest whole cent.
    b) Use another currency that has different coin amounts. For example, the US uses 1, 5, 10, and 25 cent coins called pennies, nickels, dimes, and quarters, respectively

    c*) Now that we're comfortable with boolean data types, comparison operators and logical operators, try writing a program that:
        1. Checks a password if it has uppercase letters and doesn’t include symbols (without regex)
        2. Tells you if you should watch a TV show if it has your favorite actor or is your favorite drama

**REVIEW**

BOOL TYPE: bool variableName
COMPARISON OPERATORS: ==, <, >, <=, >=
LOGICAL OPERATORS: &&, ||, !

**there is also the bitwise logical operators, check out: 
https://www.tutorialspoint.com/csharp/csharp_bitwise_operators.htm

 */

