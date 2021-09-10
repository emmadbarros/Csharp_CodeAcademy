using System;
namespace AbstractClassDemonstration
{
    public abstract class Device
    {
        //FIELD(s)
        public int IMIE_Number = 0;


        //PROPERTIES(s)
        public abstract int BatteryPercentage { get; set; } //Must be implemented in child class


        //METHODS(s)
        public void PowerOn()
        {
            //Some basic functionality
        }

        public void PowerOff()
        {
            //Some basic functionality
        }

        public abstract void PlayVideo(); //Must be implemented in child class

        public virtual void PlayAudio()
        {
            //Some functionality that can be overridden
        }


        //CONSTRUCTOR(s)
        public Device()
        {
        }
    }
}
