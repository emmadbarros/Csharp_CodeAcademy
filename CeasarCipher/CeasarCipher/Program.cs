using System;
using System.Text.RegularExpressions;

namespace CeasarCipher
{
    //Custom Exception
    public class InvalidDataException : Exception
    {
        public InvalidDataException(string msg) : base(msg) { }
        public InvalidDataException(string msg, Exception inner) : base(msg, inner) { }
    }

    class Program
    {
        //Alphabet Sequence
        static char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', ' ', '.' };

        static char[] secretMessage;

        static char[] encryptedMessage;

        //should equal secretMessage
        static char[] decryptedMessage;

        //Message Check Method
        static string MessageCheck(string userInput)
        {
            if (!Regex.IsMatch(userInput, @"^[a-z .]+$"))
            {
                throw new InvalidDataException("Secret message must only contain lower-case alphabet characters a-z, spaces and a dot.");
            }
            return userInput;
        }

        static void EncryptSecretMessage()
        {
            for (int i = 0; i < secretMessage.Length; i++)
            {
                //access the character at position i in the secretMessage array and store it in a variable.
                char letterToEncrypt = secretMessage[i];

                //find the position of the character in the alphabet array. Store the value in a variable.
                int alphabetIndex = Array.IndexOf(alphabet, letterToEncrypt);

                //add 3 to the letter position and store the value in a variable.
                int newIndex = alphabetIndex + 3;

                //find the new encrypted character by getting the character in the alphabet array with that new position.
                char newChar;

                //my alphabet has 28 characters
                if (newIndex == 28)
                {
                    newChar = 'a';
                }
                else if (newIndex == 29)
                {
                    newChar = 'b';
                }
                else if (newIndex == 30)
                {
                    newChar = 'c';
                }
                else
                {
                    newChar = alphabet[newIndex];
                }

                //add the encrypted character to the array encryptedMessage. Store the character at the index i(the iterator variable).
                encryptedMessage[i] = newChar;
            }
        }

        static void DecryptSecretMessage()
        {
            for (int i = 0; i < encryptedMessage.Length; i++)
            {
                //access the character at position i in the encryptedMessage array and store it in a variable.
                char letterToDecrypt = encryptedMessage[i];

                //find the position of the character in the alphabet array. Store the value in a variable.
                int alphabetIndex = Array.IndexOf(alphabet, letterToDecrypt);

                //subtract 3 to the letter position and store the value in a variable.
                int newIndex = alphabetIndex - 3;

                //find the new decrypted character by getting the character in the alphabet array with that new position.
                char newChar;

                //my alphabet has 28 characters
                if (newIndex == -3)
                {
                    newChar = 'z';
                }
                else if (newIndex == -2)
                {
                    newChar = ' ';
                }
                else if (newIndex == -1)
                {
                    newChar = '.';
                }
                else
                {
                    newChar = alphabet[newIndex];
                }

                //add the encrypted character to the array decryptedMessage. Store the character at the index i(the iterator variable).
                decryptedMessage[i] = newChar;
            }
        }

        static void Main(string[] args)
        {
            try
            {
                //get user input + verif
                Console.WriteLine("What is your secret message?");

                string userInput = MessageCheck(Console.ReadLine()); // InvalidDataException

                //initialize arrays
                secretMessage = userInput.ToCharArray();

                encryptedMessage = new char[secretMessage.Length];

                decryptedMessage = new char[secretMessage.Length];

                //encrypt secretMessage
                EncryptSecretMessage();

                //Convert the character array to a string using String.Join() and print it to the console.
                string encryptedMessageString = string.Join("", encryptedMessage);

                Console.WriteLine($"You're encrypted message: \n{encryptedMessageString}");

                //decrypt encryptedMessage
                DecryptSecretMessage();

                //Convert the decrypted character array to a string using String.Join() and print it to the console.
                string decryptedMessageString = string.Join("", decryptedMessage);

                Console.WriteLine($"You're decrypted message: \n{decryptedMessageString}");
            }
            catch (InvalidDataException exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}

/*
 Program Extension Ideas:

1- The program doesn't work with upper-case letters - TODO
2- The app doesn't work with symbols, like '!' or '?'. Either skip any symbols in the loop so that they are not encrypted OR add them to the alphabet array like I did with the ' ' and '.' - TODO
3- ReWrite Encrypt() and Decrypt() method to take in the secret message and cipher key as args. Ex: Encrypt(secretMessage, 3) - TODO
4- Refactor code repition ??? - FIXME
 */


/*
 **Note for myself**
 Other method for IndexOutOfBounds:

 If I had kept the alphabet at 26 letters and hadn't work around the last 3 letters with the if else statements and the program tried to encrypt the z in citizen, it would find its index in the alphabet, 25. It would look up the letter 3 spaces to the right, which would be alphabet[28].

This would throw an error because the alphabet is only 26 letters!

I could've “wrap around” by using the modulo operator: %. On the line where I add 3 to the letter position, I could surround the expression alphabetIndex + 3 with parentheses and take the modulo of 26.

Now the new letter position will never go past 26.

(same for x and y)
*/
