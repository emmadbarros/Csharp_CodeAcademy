using System;
namespace RoverControlCenter
{
    public class Satellite : IDirectable
    {
        public string Alias
        { get; private set; }

        public int YearLaunched
        { get; private set; }

        public Satellite(string alias, int yearLaunched)
        {
            Alias = alias;
            YearLaunched = yearLaunched;
        }

        //implements GetInfo() method from Interface
        public string GetInfo()
        {
            return $"Alias: {Alias}, YearLaunched: {YearLaunched}";
        }

        //implements Explore() method from Interface and makes it virtual
        public virtual string Explore()
        {
            return "Satellite is exploring the far reaches of space!";
        }

        //implements Collect() method from Interface and makes it virtual
        public virtual string Collect()
        {
            return "Satellite is collecting photographic evidence!";
        }
    }
}
