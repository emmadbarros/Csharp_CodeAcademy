using System;

namespace ChooseYourOwnAdventureGame
{
    class Program
    {
        //re-usable variables
        static string username;

        static string userAnswer;

        static int userAnswerNumber;

        static string choiceQuestion;

        static string theEnd = "THE END";

        static string intro = "It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?";

        static string hallwayPart = "You walk into the hallway and see a light coming from under a door down the hall.\nYou walk towards it. Do you open it or knock?";

        static string knockPart = "A voice behind the door speaks. It says, \"Answer this riddle: \"\n\"Poor people have it. Rich people need it. If you eat it you die. What is it?\"";

        static string lockDoorPart = "The door is locked! See if one of your three keys will open it.";

        static string keyOneChoice = "You choose the first key. Lucky choice! The door opens and NOTHING is there. Strange...";

        static string keyTwoChoice = "You choose the second key. The door doesn't open.";

        static string keyChoiceThree = "You choose the third key. The door doesn't open.";

        //user input validation methods
        static public void userInputValidation()
        {
            while (true)
            {
                choiceQuestion = "Enter a number (1-3): ";

                Console.Write(choiceQuestion);

                if (!int.TryParse(Console.ReadLine(), out userAnswerNumber))
                {
                    Console.WriteLine("Invalid character, try again.");
                    continue;
                }

                if (userAnswerNumber < 1 || userAnswerNumber > 3)
                {
                    Console.WriteLine("Choose a number between 1 and 3, try again.");
                    continue;
                }

                break;

            }
        }

        static public void userInputValidation(string answer)
        {
            //FIXME: could be refactored!
            while (true)
            {
                choiceQuestion = "Type your answer: ";

                Console.Write(choiceQuestion);

                userAnswer = Console.ReadLine();

                if (userAnswer.Equals(answer, StringComparison.CurrentCultureIgnoreCase))
                {
                    userAnswer = userAnswer.ToUpper();
                    break;
                }

                Console.WriteLine($"You answered incorrectly. The door doesn't open.\n{theEnd}");
                break;
            }

        }

        static public void userInputValidation(string choiceOne, string choiceTwo)
        {
            while (true)
            {
                choiceQuestion = $"Type {choiceOne.ToUpper()} or {choiceTwo.ToUpper()} ";

                Console.Write(choiceQuestion);

                userAnswer = Console.ReadLine();

                if (userAnswer.Equals(choiceOne, StringComparison.CurrentCultureIgnoreCase) || userAnswer.Equals(choiceTwo, StringComparison.CurrentCultureIgnoreCase))
                {
                    userAnswer = userAnswer.ToLower();
                    break;
                }

                Console.WriteLine("Invalid answer, try again.");
            }
        }

        static void Main(string[] args)
        {
            /* THE MYSTERIOUS NOISE */

            //get username
            Console.Write("Enter username: ");
            username = Console.ReadLine();

            //welcome
            Console.WriteLine($"\nHello, {username}! Welcome to our story...");

            //intro
            Console.WriteLine(intro + "\n");

            //make a choice 1 - validation
            userInputValidation("yes", "no");

            if (userAnswer.Equals("no", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine($"\n{userAnswer}!?\nNot much of an adventure if we don't leave our room!\n{theEnd}");
                return;
            }

            //hallway
            Console.WriteLine("\n" + hallwayPart + "\n");

            //make a choice 2 - validation
            userInputValidation("open", "knock");

            if (userAnswer.Equals("knock"))
            {
                Console.WriteLine("\n" + knockPart + "\n");

                userInputValidation("nothing");

                if (userAnswer.Equals("nothing", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine($"\nThe door opens and {userAnswer} is there. You turn off the light and run back to your room and lock the door.\n{theEnd}");
                    return;
                }
                else
                {
                    return;
                }
            }
            else
            {
                Console.WriteLine("\n" + lockDoorPart + "\n");

                userInputValidation();

                switch (userAnswerNumber)
                {
                    case 1:
                        Console.WriteLine($"\n{keyOneChoice}\n{theEnd}");
                        break;
                    case 2:
                        //FIXME: change storyline here
                        Console.WriteLine($"\n{keyTwoChoice}\n{theEnd}");
                        break;
                    case 3:
                        //FIXME: change storyline here
                        Console.WriteLine($"\n{keyChoiceThree}\n{theEnd}");
                        break;
                    default:
                        //FIXME: could throw InternalError custom exception..?
                        break;
                }
            }

        }
    }
}

/*
 In this project, you’ll use logic and conditional statements to write a classic text-based Choose Your Own Adventure Game. Depending on what choices your user makes, the program will have a different result. If you’re interested in game development, this is a great project to get your started! While we’re only working with text, the principles of user input and control flow are used to build even highly advanced games.

If you are feeling ambitious, here are some extensions:

    1. Modify the story and the code to create your very own Choose Your
    2. Include more cases to check for other user input (what if a user picks a choice you didn’t include?)
    3. Use ternary operators
 */