using System;
namespace AppInterfaces
{
    public interface IDisplayable
    {
        public string HeaderSymbol { get; }

        public void Display();
    }
}
