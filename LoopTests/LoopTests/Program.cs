using System;

namespace LoopTests
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                //Uncomment methods

                //Loops through a piece of text and only prints words that start with the letter “a” to the console to create a poem.
                PrintPoem();

                //Loops through a list of numbers and if it is even, print even and if it’s odd, print odd.
                //OddOrEven();

                //A Choose Your Own Adventure game that uses a while loop to make sure a user chooses a correct option.
                //ChooseGameMode();

                //Test();
            }

            //Poem
            static void PrintPoem()
            {

                string text = "Pokem ipsum dolor sit amet Exeggutor Kecleon Wing Attack Doduo Red Unown. Sunt in culpa Drilbur Calcium Hoenn Shieldon Wynaut Charizard. Growl Venonat Scolipede Espeon Charizard Barboach Hidden Machine. Duis aute irure dolor in reprehenderit in voluptate they're comfy and easy to wear Onix what kind of Pokemon are you Fog Badge Ampharos Noctowl. Pewter City Marill Slakoth Bronzong Rattata Treecko Cottonee.";

                string[] wordsInText = text.Split();

                Console.WriteLine("Your pokemon poem is: ");

                foreach (string word in wordsInText)
                {
                    char firstLetter = word[0];

                    if (firstLetter == 'a' || firstLetter == 'A')
                    {
                        Console.WriteLine(word);
                    }
                }
            }

            //Odd or Even
            static void OddOrEven()
            {
                Random rand = new Random();

                int[] randomNumberSeries = new int[20];

                for (int i = 0; i < randomNumberSeries.Length; i++)
                {
                    randomNumberSeries[i] = rand.Next(0, 101);
                }

                foreach (int i in randomNumberSeries)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine($"{i} is even!");
                    }
                    else
                    {
                        Console.WriteLine($"{i} is odd!");
                    }
                }
            }

            //Game Mode
            static void ChooseGameMode()
            {
                bool soloOrMulti = false;
                do
                {
                    try
                    {
                        Console.WriteLine("Welcome to the game! Choose a game mode:\n1- Solo\n2- Multiplayer\nGood Luck!");

                        int gameMode = int.Parse(Console.ReadLine()); //format exc

                        if (gameMode < 1 || gameMode > 2)
                        {
                            throw new FormatException();
                        }

                        if (gameMode == 1)
                        {
                            Console.WriteLine("Welcome to solo mode!");
                            soloOrMulti = true;
                        }
                        else
                        {
                            Console.WriteLine("Welcome to Multiplayer mode!");
                            soloOrMulti = true;
                        }
                    }
                    catch (FormatException exc)
                    {
                        Console.WriteLine("Invalid character, only integer 1 or 2 allowed!" + exc.Message);
                    }


                } while (soloOrMulti == false);
            }

            static void Test()
            {
                for (int z = 2; z < 4; z++)
                {
                    Console.WriteLine("bzzt");
                }
            }

            static void Test2()
            {
                //1. NOT GOOD
                //int[] array = new int[];

                //2.
                int[] array2 = new int[10];

                //3.
                int[] array3 = new int[] { 1, 2, 3, 4 };

                //4.
                int[] array4 = new int[5] { 1, 2, 3, 4, 5 };

                //5. NOT GOOD
                //int[] array5 = int[];

                //6. NOT GOOD
                //int[] array6 = int[] { 1, 2, 3, 4, 5};

                //7.
                int[] array7 = { 1, 2, 3, 4, 5 };
            }
        }
    }
}
