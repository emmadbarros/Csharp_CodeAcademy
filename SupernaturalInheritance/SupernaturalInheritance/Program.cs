using System;

namespace SupernaturalInheritance
{
    class Program
    {
        static Storm[] storms = new Storm[4];

        static void Main(string[] args)
        {
            //PUPIL
            Console.WriteLine("PUPIL");

            Pupil mez = new Pupil("Mezil-kree", "Icecrown");

            storms[0] = mez.CastWindStorm();

            Console.WriteLine(storms[0].Announce());
            Console.WriteLine();

            //MAGE
            Console.WriteLine("MAGE");

            Mage gul = new Mage("Gul'dan", "Draenor");

            storms[1] = gul.CastRainStorm();

            Console.WriteLine(storms[1].Announce());
            Console.WriteLine();

            //ARCHMAGE
            Console.WriteLine("ARCHMAGE");

            Archmage niel = new Archmage("Nielas Aran", "Stormwind");

            storms[2] = niel.CastRainStorm();
            storms[3] = niel.CastLightningStorm();

            Console.WriteLine(storms[2].Announce());
            Console.WriteLine(storms[3].Announce());
            Console.WriteLine();
        }
    }
}


/*
 *** EXTENSIONS ***

1- In Program.cs, store the Storm objects in an array instead of separate variables.
 */
