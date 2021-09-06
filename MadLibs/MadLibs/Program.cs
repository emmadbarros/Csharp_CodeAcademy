using System;

namespace MadLibs
{
    class Program
    {
        //Mad Libs Word Game Intro:

        static public void Greeting()
        {

            var title = "Mad Libs Word Game";

            Console.WriteLine($"~~ {title} has started! ~~");
        }

        static void Main(string[] args)
        {
            //Intro
            Greeting();

            //Define user input and variables:
            Console.WriteLine("Please enter a name for the main character:");
            string mainCharacterName = Console.ReadLine();

            Console.WriteLine("You will be prompted to enter 3 different adjectives for the main character of this story, like a color, a feeling or a texture for example.\nEnter 1st adjective:");
            string adjectiveOne = Console.ReadLine();

            Console.WriteLine("Enter 2nd adjective:");
            string adjectiveTwo = Console.ReadLine();

            Console.WriteLine("Enter 3rd adjective:");
            string adjectiveThree = Console.ReadLine();

            Console.WriteLine("Now, enter a verb associated with the main character, like 'sit', 'eat' or 'sleep':");
            string verb = Console.ReadLine();

            Console.WriteLine("You will now be prompted to input two nouns for the story, like 'girl', 'cabin' or 'toaster'.\nEnter first noun:");
            string nounOne = Console.ReadLine();

            Console.WriteLine("Enter second noun:");
            string nounTwo = Console.ReadLine();

            Console.WriteLine("Please enter an animal:");
            string animal = Console.ReadLine();

            Console.WriteLine("Please enter a food:");
            string food = Console.ReadLine();

            Console.WriteLine("Please enter a fruit:");
            string fruit = Console.ReadLine();

            Console.WriteLine("Please enter a superhero:");
            string superhero = Console.ReadLine();

            Console.WriteLine("Please enter a country:");
            string country = Console.ReadLine();

            Console.WriteLine("Please enter a dessert:");
            string dessert = Console.ReadLine();

            Console.WriteLine("Please enter a year:");
            string year = Console.ReadLine();

            // The template for the story:
            string story = $"This morning {mainCharacterName} woke up feeling {adjectiveOne}. 'It is going to be a {adjectiveTwo} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {nounOne}, which made all the {fruit}s very {adjectiveThree}. Concerned, {mainCharacterName} texted {superhero}, who flew {mainCharacterName} to {country} and dropped {mainCharacterName} in a puddle of frozen {dessert}. {mainCharacterName} woke up in the year {year}, in a world where {nounTwo}s ruled the world.";

            Console.WriteLine(story);

        }
    }
}

/*
 In this project, we’ll use C# to write a Mad Libs word game! Mad Libs are short stories with blanks for the player to fill in that represent different parts of speech. The end result is a really hilarious and strange story.

Mad Libs require: A short story with blank spaces (asking for different types of words). Words from the player to fill in those blanks.

For this project, we have provided the story, but it will be up to you to complete the following: Prompt the user for inputs. Print the story with the inputs in the right places.
 */
