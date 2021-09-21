using System;
using System.Collections.Generic;

namespace ProgrammingLanguages
{
    public class Language
    {
        //Tool functions (static)
        public static Language FromTsv(string tsvLine)
        {
            string[] values = tsvLine.Split('\t');

            Language lang = new Language(
              Convert.ToInt32(values[0]),
              Convert.ToString(values[1]),
              Convert.ToString(values[2]),
              Convert.ToString(values[3]));

            return lang;
        }

        public static void PrettyPrintAll(IEnumerable<Language> lang)
        {
            foreach(var l in lang)
            {
                Console.WriteLine(l.Prettify());
            }
        }

        public static void PrintAll(IEnumerable<Object> lang)
        {
            foreach (var l in lang)
            {
                Console.WriteLine(l);
            }
        }

        public int Year
        { get; set; }

        public string Name
        { get; set; }

        public string ChiefDeveloper
        { get; set; }

        public string Predecessors
        { get; set; }

        public Language(int year, string name, string chiefDeveloper, string predecessors)
        {
            Year = year;
            Name = name;
            ChiefDeveloper = chiefDeveloper;
            Predecessors = predecessors;
        }

        public string Prettify()
        {
            return $"{Year}, {Name}, {ChiefDeveloper}, {Predecessors}";
        }
    }
}


//For better design of FromTsv() method:
//make sure each line only contains 4 elements
//catch Convert() exception
//use TryParse()
//is it better to catch the exception here or in setter...?