using System;
namespace SupernaturalInheritance
{
    public class Pupil
    {
        //FIELD(s)




        //PROPERTIE(s)
        public string Title
        {
            get;
            private set;
        }

        public string Origin
        {
            get;
            private set;
        }



        //CONSTRUCTOR(s)
        public Pupil(string title, string origin = "Unknown")
        {
            this.Title = title;
            this.Origin = origin;
        }


        //METHOD(s)
        public Storm CastWindStorm()
        {
            return new Storm("wind", false, Title);
        }
    }
}
