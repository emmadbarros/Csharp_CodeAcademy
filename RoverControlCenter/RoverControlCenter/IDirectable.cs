using System;
namespace RoverControlCenter
{
    public interface IDirectable
    {
        public string GetInfo();
        public string Explore();
        public string Collect();
    }
}
