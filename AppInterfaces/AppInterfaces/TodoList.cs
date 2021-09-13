using System;
namespace AppInterfaces
{
    public class TodoList : IDisplayable
    {
        //FIELD(s)
        private int nextOpenIndex;


        //PROPERTIE(s)
        public string[] Todos
        { get; private set; }


        //CONSTRUCTOR(s)
        public TodoList()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
        }


        //METHOD(s)
        public void Add(string todo)
        {
            if (nextOpenIndex > 4)
            {
                throw new InvalidCastException("Sorry, 5 todos maximum in a list.");
            }
            Todos[nextOpenIndex] = todo;
            nextOpenIndex++;
            //The way CodeAcademy designed this class, IndexOutOfBounds exc if user adds more than 5 tds!!!
        }

        public void Display()
        {
            Console.WriteLine("Your todos: ");
            foreach (string td in Todos)
            {
                Console.WriteLine($"> {td}");
            }
        }
    }
}
