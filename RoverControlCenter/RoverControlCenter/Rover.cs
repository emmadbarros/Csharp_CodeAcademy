using System;
namespace RoverControlCenter
{
    public class Rover : IDirectable
    {
        public string Alias
        { get; private set; }

        public int YearLanded
        { get; private set; }

        public Rover(string alias, int yearLanded)
        {
            Alias = alias;
            YearLanded = yearLanded;
        }

        //implements GetInfo() method from Interface
        public string GetInfo()
        {
            return $"Alias: {Alias}, YearLanded: {YearLanded}";
        }

        //implements Explore() method from Interface and makes it virtual
        public virtual string Explore()
        {
            return "Rover is exploring the surface!";
        }

        //implements Collect() method from Interface and makes it virtual
        public virtual string Collect()
        {
            return "Rover is collecting rocks!";
        }
    }
}
