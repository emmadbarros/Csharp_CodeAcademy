using System;
namespace SupernaturalInheritance
{
    public class Storm : Spell
    {

        //FIELD(s)



        //PROPERTIE(s)



        //CONSTRUCTOR(s)
        public Storm(string essence, bool isStrong, string caster) : base(essence, isStrong, caster)
        {
        }


        //METHOD(s)
        public override string Announce()
        {
            return String.Format("{0} cast a {1} {2} storm!", Caster, IsStrong ? "strong" : "weak", Essence);
        }
    }
}
