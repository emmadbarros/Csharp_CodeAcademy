using System;
namespace SupernaturalInheritance
{
    public class Mage : Pupil
    {
        //FIELD(s)

        //PROPERTIE(s)


        //CONSTRUCTOR(s)
        public Mage(string title, string origin = "Unknown") : base(title, origin)
        {
        }

        //METHOD(s)
        public virtual Storm CastRainStorm()
        {
            return new Storm("rain", false, this.Title);
        }
    }
}
