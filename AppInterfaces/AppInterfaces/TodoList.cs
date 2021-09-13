using System;
namespace AppInterfaces
{
    public class TodoList : IDisplayable, IResetable
    {
        //FIELD(s)
        private int nextOpenIndex;


        //PROPERTIE(s)
        public string[] Todos
        { get; private set; }

        public string HeaderSymbol => "-";


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
            Console.WriteLine("TODOS");
            for (int x = 0; x < 10; x++)
            {
                Console.Write(HeaderSymbol);
                if (x == 9)
                {
                    Console.WriteLine();
                }
            }
            foreach (string td in Todos)
            {
                if (string.IsNullOrEmpty(td))
                {
                    Console.WriteLine("> []");
                } else
                {
                    Console.WriteLine($"> {td}");
                }
            }
        }

        public void Reset()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
        }
    }
}
