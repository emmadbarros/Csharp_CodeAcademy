using System;

namespace AppInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TodoList tdl = new TodoList();
                tdl.Add("Invite friends");
                tdl.Add("Buy decorations");
                tdl.Add("Party");
                //The way CodeAcademy designed this class, IndexOutOfBounds exc if user adds more than 5 tds!!!

                PasswordManager pm = new PasswordManager("iluvapplepie", true);

                //1st call
                tdl.Display();
                Console.WriteLine();
                pm.Display();
                Console.WriteLine();

                //reset
                tdl.Reset();
                pm.ChangePassword("iloveapplepie", "ilovecherryponpon");

                //2nd call
                tdl.Display();
                Console.WriteLine();
                pm.Display();

            }
            catch (InvalidDataException exc)
            {
                Console.WriteLine(exc.Message);
                //usually, with a user interface, we wouldn't want to crash to terminate the program because of this type of 'error' from the user
            }
        }
    }
}


/*
 *** App Interface Project ***

The team at Computron Computing has asked you to join their product team to develop the hottest new Computron computer. You’ll be responsible for building some of the standard apps on this new machine, specifically the to-do list and the password manager.

At this point in development you have two classes started: TodoList representing the to-do list application and PasswordManager representing the password manager. In order to work within the Computron system, every app must have a display and reset feature. In other words, each class will need to implement the IDisplayable and IResetable interfaces.

*** OPTIONAL CHALLENGES ***

1- Add a get-only property to IDisplayable called HeaderSymbol. This should be used in Display() as a header. For example, if the header symbol is -, then the apps should be displayed as:

    Todos
    ----------
    Eat
    Sleep
    Code

    Password
    ----------
    ***

2- If you add more than five to-dos to the TodoList, it throws an error! Extend the Add() method so that it doesn’t add any more than five items to the Todos array.

3- Currently a blank line is printed for each empty index in Todos. Change Display() in TodoList so that it prints [] instead of a blank line. You’ll need to use the static method String.IsNullOrEmpty().

4- Add a method ChangePassword() to PasswordManager. It should:

    - have two string parameters
    - if the first argument matches the existing Password, reset the Password to the second argument
    - return true if the password change was a success (the first argument matched the old password), and false otherwise

5- Extend the Password property in PasswordManager:

    - Change the set method so that it requires the password to be at least eight characters in length 
 */
