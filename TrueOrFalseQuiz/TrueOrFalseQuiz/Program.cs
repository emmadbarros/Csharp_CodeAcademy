using System;

namespace TrueOrFalseQuiz
{
    //Custom Exceptions
    public class InvalidDataException : Exception
    {
        public InvalidDataException(string msg) : base(msg) { }
        public InvalidDataException(string msg, Exception inner) : base(msg, inner) { }
    }

    public class InternalError : Exception
    {
        public InternalError(string msg) : base(msg) { }
        public InternalError(string msg, Exception inner) : base(msg, inner) { }
    }

    class Program
    {

        static string[] questions = { "Are blueberries purple?", "Is Cherry a big baby?", "Do I love watching Suits?" };

        static bool[] answers = { false, true, true };

        static bool[] responses = new bool[answers.Length];

        static void RunQuiz(string[] questions, bool[] answers)
        {
            //initial verification
            if (questions.Length != answers.Length)
            {
                throw new InternalError("Something went wrong in the program logic.");
            }

            //flag
            int askingIndex = 0;

            //iterate through the questions array
            foreach (string question in questions)
            {
                //define empty variables
                string input;
                bool inputBool;
                bool isBool = false;

                //ask the question to the user
                Console.WriteLine(question);
                Console.WriteLine("True or False");

                while (!isBool)
                {
                    //get user input
                    input = Console.ReadLine();

                    //doesn't throw FormatException
                    //could've declared the out parameter in the TryParse as well (input, out bool inputBool);
                    isBool = bool.TryParse(input, out inputBool);

                    if (isBool)
                    {
                        //add the user's answer to the answers array
                        responses[askingIndex] = inputBool;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please respond with 'true' or 'false'");
                        continue;
                    }
                }

                askingIndex++;

            }

            //get score

            int scoringIndex = 0, score = 0;

            foreach (bool answer in answers)
            {
                bool response = responses[scoringIndex];

                scoringIndex++;

                if (answer == response)
                {
                    score++;
                }

                Console.WriteLine($"Input: {response} | Answer: {answer}");
            }

            Console.WriteLine($"You got {score} out of {questions.Length}!");

        }

        static void Main(string[] args)
        {
            try
            {

                RunQuiz(questions, answers);

            }
            catch (Exception exc) when (exc is InvalidDataException || exc is InternalError)
            {
                //didn't use InvalidDataException
                Console.WriteLine(exc.Message);
            }
        }
    }
}

/*
This app can run a true or false quiz, gracefully handle user input, and calculate user scores.

TODO:
If you wanted to make multiple quizzes, you would have to type out the same code multiple times. Fix this issue by refactoring your code into a method RunQuiz(). It should take two arguments: a string[] array of questions and bool[] array of answers. It should have the same behavior as your current app.
*/
