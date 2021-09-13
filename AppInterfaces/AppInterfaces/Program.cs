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
                tdl.Add("Invite friends");
                tdl.Add("Buy decorations");
                tdl.Add("Party");
                //The way CodeAcademy designed this class, IndexOutOfBounds exc if user adds more than 5 tds!!!

                PasswordManager pm = new PasswordManager("iluvpie", true);
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

 */
