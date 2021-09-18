using System;

namespace RoverControlCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
            MoonRover apollo = new MoonRover("Apollo 15", 1971);
            MarsRover sojourner = new MarsRover("Sojourner", 1997);
            Satellite sputnik = new Satellite("Sputnik", 1957);

            Rover[] rovers = { lunokhod, apollo, sojourner };

            //DirectAll(rovers);

            /*
            Object[] objects = { lunokhod, apollo, sojourner, sputnik };

            foreach(Object obj in objects)
            {
                Console.WriteLine($"Tracking a {obj.GetType()}");
            }
            */

            IDirectable[] probes = { lunokhod, apollo, sojourner, sputnik };

            DirectAll(probes);


        }

        static void DirectAll(IDirectable[] probes)
        {
            foreach(IDirectable probe in probes)
            {
                Console.WriteLine(probe.GetInfo());
                Console.WriteLine(probe.Explore());
                Console.WriteLine(probe.Collect());
                Console.WriteLine();
            }
        }
    }
}

/*
  
 * 
 * This exercice is meant to understand the principle of inheritance, interfaces, references, overriding, etc.
 * 
 
 The Object array isn’t very useful because you can’t direct the probes to keep collecting and exploring!

We’ll need to create another shared class or interface. We have two options:

    - Create a superclass Probe that Rover and Satellite inherit from
    - Create an interface IDirectable that Rover and Satellite implement

The first option would involve a lot of changes to Rover and Satellite, like moving methods out of Rover and Satellite and into Probe or making those methods override.

It will be easier to just create a shared interface, which doesn’t require writing or changing any methods.

In IDirectable.cs, define an interface IDirectable with three methods:

    - string GetInfo()
    - string Explore()
    - string Collect()


With a shared interface, we can manage Rover and Satellite types in the same array.

Back in Program.cs, create an array of type IDirectable[] containing all the probes (three rovers and one satellite).


*** OPTIONAL EXTENSIONS ***

- In Task 6, we decided to create a shared interface over a shared superclass. To prove that making a shared superclass really is more work, try it yourself: Remove the interface and create a shared Probe superclass. Instead of an array of type IDirectable[], make an array of type Probe[].

- Try to answer this question on your own: in task 3, you called the Explore() and Collect() methods on each rover. Even though you used Rover references, the specific rover type (MoonRover or MarsRover) was printed. How is that possible?
  Ans: Because the superclass reference has access to the overriden methods in each subclass
 */
