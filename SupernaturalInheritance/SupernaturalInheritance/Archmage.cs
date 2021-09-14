using System;
namespace SupernaturalInheritance
{
    public class Archmage : Mage
    {
        //FIELD(s)


        //PROPERTIE(s)


        //CONSTRUCTOR(s)
        public Archmage(string title, string origin = "Unknown") : base(title, origin)
        {
        }

        //METHOD(s)
        public override Storm CastRainStorm()
        {
            return new Storm("rain", true, this.Title);
        }

        public Storm CastLightningStorm()
        {
            return new Storm("lightning", true, this.Title);
        }
    }
}
