using System;
using System.Text.RegularExpressions;

namespace PasswordChecker
{
    class Program
    {
        //password standards
        static int minLengt = 8;

        //use regex instead
        /*
        static string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static string lowercase = "abcdefghijklmnopqrstuvwxyz";
        static string digits = "0123456789";
        static string specialChars = "!?.-_()*%?@#$";
        */

        //satisfied standards score /5
        static int score = 0;

        //user input variable
        static string password;

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Password minimum requirements:\n1- Minimum 8 characters\n2- Must contain at least 1 uppercase letter\n3- Must contain at least 1 lowercase letter\n4- Must contain at least 1 digit\n5- Must contain at least one special character '!?.-_()*%?@#$'\nEnter your password:");

                password = Console.ReadLine();

                if (password.Length >= minLengt)
                    score++;

                if (Regex.IsMatch(password, @"[A-Z]"))
                    score++;

                if (Regex.IsMatch(password, @"[a-z]"))
                    score++;

                if (Regex.IsMatch(password, @"[0-9]"))
                    score++;

                if (Regex.IsMatch(password, @"[_!@#$%?&*()-.]"))
                    score++;

                if (password.Equals("password") || password.Equals("1234"))
                    score = 0;

                //stackoverflow: You can't - switch/case is only for individual values. If you want to specify conditions, you need an "if":
                if (score >= 4)
                {
                    Console.WriteLine($"Your score is: {score} / 5 - VERY STRONG");
                }
                else
                {
                    switch (score)
                    {
                        case 3:
                            Console.WriteLine($"Your score is: {score} / 5 - STRONG");
                            break;
                        case 2:
                            Console.WriteLine($"Your score is: {score} / 5 - MEDIUM");
                            break;
                        case 1:
                            Console.WriteLine($"Your score is: {score} / 5 - WEAK");
                            break;
                        default:
                            Console.WriteLine($"Your score is: {score} / 5 - your password doesn't meat any of the standards.");
                            break;
                    }
                }

            }
            finally
            {
                Console.WriteLine("Press any key to finish...");
                Console.ReadKey();
            }
        }
    }
}


/*
**PASSWORD CHECKER**

A computer can run thousands of operations per minute. If someone wanted to steal your information, they use each operation to make a guess at your password. With one high-performance computer and the right software, a 6 letter single-case password can be broken in one day.

see: https://en.wikipedia.org/wiki/Password_strength#Password_guess_validation

Apart from quitting the internet entirely, what can we do to protect ourselves? We can increase our password’s strength: make it longer and more complex.

In this project you’ll make a program that measures the strength of any given password based on the following criteria. A strong password:

    - is at least 8 characters long
    - has lowercase letters
    - has uppercase letters
    - has numerical digits
    - has symbols, like #, ?, !

The program will ask the user to input a password, and using conditional logic and control flow, it will rate the password.

 */