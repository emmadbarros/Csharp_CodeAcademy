using System;
namespace SupernaturalInheritance
{
    public abstract class Spell
    {
        //FIELD(s)



        //PROPERTIE(s)
        public string Essence
        {
            get;
            private set;
        }

        public bool IsStrong
        {
            get;
            private set;
        }

        public string Caster
        {
            get;
            private set;
        }



        //CONSTRUCTOR(s)
        public Spell(string essence, bool isStrong, string caster)
        {
            this.Essence = essence;
            this.IsStrong = isStrong;
            this.Caster = caster;
        }


        //METHOD(s)
        public abstract string Announce();
    }
}
