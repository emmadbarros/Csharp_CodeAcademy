using System;
namespace InterfaceDemonstration
{
    interface IFruit
    {
        //can't have variables/fields in Interfaces
        //can't have implementations, just declarations
        //all methods declared are by default public

        //PROPERTIE(s)
        string Description { get; set; }

        //Method(s)
        string Name();
        string Season();
        string Colour();
    }
}
