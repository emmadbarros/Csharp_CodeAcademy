using System;

namespace ConsoleCreatures
{
    class Program
    {
        static void Main(string[] args)
        {
            //This program is simply printing out a creature to the console

            //head
            Console.WriteLine(" .-.");
            //eyes
            Console.WriteLine("(o o)");
            //mouth
            Console.WriteLine("| O |");
            //body
            Console.WriteLine("|   |");
            Console.WriteLine("'~~~'");
            //name
            Console.WriteLine("Hi, I'm Boo!");
        }
    }
}

/*
 Try the Dancing Man:

c_     ___
　 \\__|__|__
　　 \( o_o)
　　　 > ~  >
　　　/ 　 / \\
　　 /　　/　 \\
　　 \　 )　　c/
　　/　 /
　 /　/|
　(　( \
　|　|  \
　| / \  )
　| |　) |
 /  )(_/
(_ /

Remember:

The backslash \ is an escape character in C#, so \" will show up as one quote in the output (") and \\ will show up as one backslash in the output (\).

Spaces matter! " (" is not the same as "(".

 */
