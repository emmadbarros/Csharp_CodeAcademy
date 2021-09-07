using System;

namespace DatingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to our dating app! Please create a profile.");

                //get user input
                Console.WriteLine("\nEnter your name: ");
                string name = Console.ReadLine();

                int age;
                while (true)
                {
                    Console.WriteLine("\nEnter your age: ");
                    if (!int.TryParse(Console.ReadLine(), out age))
                    {
                        Console.WriteLine("\nOnly digits from 0-9 allowed, please try again.");
                        continue;
                    }
                    break;
                }

                Console.WriteLine("\nEnter your pronouns (He, She or They): ");
                string pronoun = Console.ReadLine();

                Console.WriteLine("\nEnter your City: ");
                string city = Console.ReadLine();

                Console.WriteLine("\nEnter your Country: ");
                string country = Console.ReadLine();

                Console.WriteLine("\nEnter a brief description of yourself: ");
                string description = Console.ReadLine();

                Profile userProfile = new Profile(name, age, pronoun, city, country, description);

                Console.WriteLine("\n" + userProfile.ToString());

            }
            catch (InvalidDataException exc)
            {
                Console.WriteLine("\n" + exc.Message);
            }
        }
    }
}


/*
 INITIAL PROJECT REQUIREMENTS:

Add the following fields to Profile:

    - string name
    -  int age
    - string city
    - string country
    - string pronouns
    - string[] hobbies

We could implement these as properties, but we’ll use fields. Properties are used to:

    - validate values
    - control external access

Later in this project you’ll see how we achieve the same result with methods.






*** IMPROVEMENTS ***
FIXME: instead of having setters throw an exception and displaying one error at a time to the user, add error message to an ArrayList and display content to the user all at once.
 */
