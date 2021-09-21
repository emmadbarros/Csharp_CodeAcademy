using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProgrammingLanguages
{
    class Program
    {

        static readonly string filepath = @"/Users/emmadebarros/Projects/CodeAcademy_C#/ProgrammingLanguages/ProgrammingLanguages/languages.tsv";

        static void Main(string[] args)
        {
            /*
             Exercise 1:
            Let’s start by printing all of the languages: print each item in languages by calling its Prettify() method.

            //for better design, be ready to catch FileNotFound Exc
            List<Language> languages = File.ReadAllLines(filepath)
              .Skip(1)
              .Select(line => Language.FromTsv(line)).ToList();

            foreach(var language in languages)
            {
                Console.WriteLine(language.Prettify());
            }

            Language.PrettyPrintAll(languages);
            */

            /*
             Exercise 2:
            Write a query that returns a string for each language. It should include the year, name, and chief developer of each language.

            List<string> languages = File.ReadAllLines(filepath)
              .Skip(1)
              .Select(line => $"Year: {Language.FromTsv(line).Year}, Name: {Language.FromTsv(line).Name}, Chief Dev: {Language.FromTsv(line).ChiefDeveloper}")
              .ToList();

            foreach (string language in languages)
            {
                Console.WriteLine(language);
            }

            Language.PrintAll(languages);
            */

            /*
             Exercise 3:
            Find the language(s) with the name "C#". Use the Prettify() method to print the results to the console.

            List<Language> csharp = File.ReadAllLines(filepath)
                .Skip(1)
                .Where(line => line.Contains("C#"))
                .Select(line => Language.FromTsv(line))
                .ToList();

            foreach (var language in csharp)
            {
                Console.WriteLine(language.Prettify());
            }

            Language.PrettyPrintAll(csharp);
            */

            /*
             Exercise 4:
            Microsoft invented a bunch of languages, not just C#!

            Find all of the languages which have "Microsoft" included in their ChiefDeveloper property.

            List<Language> microsoft = File.ReadAllLines(filepath)
                .Skip(1)
                .Where(line => Language.FromTsv(line).ChiefDeveloper.Contains("Microsoft"))
                .Select(line => Language.FromTsv(line))
                .ToList();

            foreach (var language in microsoft)
            {
                Console.WriteLine(language.Prettify());
            }

            Language.PrettyPrintAll(microsoft);
            */

            /*
             Exercise 5:
            Find all of the languages that descend from Lisp.

            List<Language> lisp = File.ReadAllLines(filepath)
                .Skip(1)
                .Where(line => line.Contains("Lisp"))
                .Select(line => Language.FromTsv(line))
                .ToList();

            foreach (var language in lisp)
            {
                Console.WriteLine(language.Prettify());
            }

            Language.PrettyPrintAll(lisp);
            */

            /*
             Exercise 6:
            Programmers really like to call their languages “scripts”.

            Find all of the language names that contain the word "Script" (capital S). Make sure the query only selects the name of each language.

            List<string> scripts = File.ReadAllLines(filepath)
                .Skip(1)
                .Where(line => Language.FromTsv(line).Name.Contains("Script"))
                .Select(line => Language.FromTsv(line).Name)
                .ToList();

            foreach (var language in scripts)
            {
                Console.WriteLine(language);
            }

            Language.PrintAll(scripts);
            */

            /*
             Exercise 7:
            How many languages are included in the languages list?
            or:
            var lineCount = File.ReadLines(@"C:\file.txt").Count();

            List<Language> languages = File.ReadAllLines(filepath)
              .Skip(1)
              .Select(line => Language.FromTsv(line)).ToList();

            Console.WriteLine($"There is {languages.Count} languages in the list.");
            */

            /*
             Exercise 8:
            How many languages were launched between 1995 and 2005?

            List<Language> years = File.ReadAllLines(filepath)
                .Skip(1)
                .Where(line => Language.FromTsv(line).Year >= 1995 && Language.FromTsv(line).Year <= 2005)
                .Select(line => Language.FromTsv(line))
                .ToList();

            foreach (var language in years)
            {
                Console.WriteLine(language.Prettify());
            }

            Language.PrettyPrintAll(years);
            */

            /*
             Exercise 9:
            In your query add a Select operation that returns a string of this format for each element:   NAME was invented in YEAR

            List<Language> years = File.ReadAllLines(filepath)
                .Skip(1)
                .Where(line => Language.FromTsv(line).Year >= 1995 && Language.FromTsv(line).Year <= 2005)
                .Select(line => Language.FromTsv(line))
                .ToList();

            foreach (var language in years)
            {
                Console.WriteLine($"{language.Name} was invented in {language.Year}");
            }

            Language.PrettyPrintAll(years);
            */

            /*
             Challenge 1:

            List<Language> languages = File.ReadAllLines(filepath)
                .Skip(1)
                .Select(line => Language.FromTsv(line))
                .OrderBy(l => l.Name)
                .ToList();

            Language.PrettyPrintAll(languages);
            */

            /*
             Challenge 2:

            var oldest = File.ReadAllLines(filepath)
                .Skip(1)
                .Select(line => Language.FromTsv(line).Year)
                .Min();

            Console.WriteLine($"Oldest language year: {oldest}");
            */


        }
    }
}

/*
 *** OPTIONAL EXTENSIONS ***

1- Your queries are currently sorted by year since the languages list was sorted by year. Try sorting a query alphabetically (on the name of each language) using the OrderBy() method.

2- Find the oldest language in the list using the Min() method.
*/
